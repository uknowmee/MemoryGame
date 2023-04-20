using System;
using System.Windows.Forms;
using MemoryGame.Classes;

namespace MemoryGame
{
    public partial class SettingsScreen : Form
    {
        private readonly DataBase _dataBase;
        private readonly LoggedIn _loggedIn;

        private readonly Settings _oldSettings;
        private readonly Settings _newSettings;
        private readonly Game _game;
        private readonly GameScreen _gameScreen;

        public SettingsScreen(Settings oldSettings, Game game, DataBase dataBase, GameScreen gameScreen, LoggedIn loggedIn)
        {
            _dataBase = dataBase;
            _loggedIn = loggedIn;

            _oldSettings = oldSettings;
            _newSettings = new Settings(_oldSettings);
            _game = game;
            _gameScreen = gameScreen;

            InitializeComponent();

            LoadLabels();
        }

        private void LoadLabels()
        {
            string str = "";

            switch (_newSettings.GetLevel)
            {
                case (int)Settings.Level.Demo:
                    str = "*";
                    break;
                case (int)Settings.Level.Easy:
                    str = "**";
                    break;
                case (int)Settings.Level.Normal:
                    str = "***";
                    break;
                case (int)Settings.Level.Hard:
                    str = "*****";
                    break;
                case (int)Settings.Level.Pro:
                    str = "******";
                    break;
            }

            labelLevel.Text = (str + (Settings.Level) _newSettings.GetLevel) + str;
            labelInitVisib.Text = _newSettings.ShowVisib + @"s";
            labelVisib.Text = _newSettings.Visib + @"s";
        }

        private void SettingsScreen_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
        
        private void ChangeLevel(bool plus, bool minus)
        {
            if (_game != null)
            {
                if (_game.Paused || _game.Started || _game.AllUp || !_game.AllDown)
                {
                    MessageBox.Show(@"CANT CHANGE IT WHILE PLAYING", @"LEVEL CHANGE DENIED", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                
                    return;
                }
            }
            
            if (plus)
            {
                _newSettings.PlusLevel();

            } else if (minus)
            {
                _newSettings.MinusLevel();
            }
            LoadLabels();
        }
        
        private void ChangeInitVisib(bool plus, bool minus)
        {
            if (_game != null)
            {
                if (_game.Paused || _game.Started || _game.AllUp || !_game.AllDown)
                {
                    MessageBox.Show(@"CANT CHANGE IT WHILE PLAYING", @"INITIAL VISIBILITY CHANGE DENIED", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                
                    return;
                }
            }

            if (plus)
            {
                _newSettings.PlusShowVisib();

            } else if (minus)
            {
                _newSettings.MinusShowVisib();
            }
            LoadLabels();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (!_loggedIn.IsLoggedIn)
            {
                _oldSettings.SetAs(_newSettings);
            }
            else if (_loggedIn.IsLoggedIn)
            {
                if (_oldSettings.Visib != _newSettings.Visib && (_game.Started || _game.Seen))
                {
                    _game.Visibility.Add(_oldSettings.Visib);
                }
                
                _oldSettings.SetAs(_newSettings);

                _dataBase.UpdateSettings(_loggedIn.Login, _oldSettings);
                
                if (_game.Started)
                {
                    _gameScreen.TimerAreTwo.Interval = _game.Settings.Visib * 1000;
                }
            }
            Close();
        }

        private void buttonPlusLevel_Click(object sender, EventArgs e)
        {
            ChangeLevel(true, false);
        }

        private void buttonMinusLevel_Click(object sender, EventArgs e)
        {
            ChangeLevel(false, true);
        }

        private void buttonMinusInitVisib_Click(object sender, EventArgs e)
        {
            ChangeInitVisib(false, true);
        }

        private void buttonPlusInitVisib_Click(object sender, EventArgs e)
        {
            ChangeInitVisib(true, false);
        }

        private void buttonMinusVisib_Click(object sender, EventArgs e)
        {
            _newSettings.MinusVisib();
            LoadLabels();
        }

        private void buttonPlusVisib_Click(object sender, EventArgs e)
        {
            _newSettings.PlusVisib();
            LoadLabels();
        }
    }
}