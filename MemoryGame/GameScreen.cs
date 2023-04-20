using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Timers;
using System.Windows.Forms;
using MemoryGame.Classes;
using Timer = System.Timers.Timer;

namespace MemoryGame
{
    public partial class GameScreen : Form
    {
        private readonly DataBase _dataBase;
        private readonly LoggedIn _loggedIn;

        private readonly Settings _settings;
        private Game _game;
        private Timer _timerAreTwo;

        private readonly InitScreen _initScreen;
        private SettingsScreen _settingsScreen;
        private ScoresScreen _scoresScreen;

        private readonly List<Image> _images;
        private readonly List<Button> _buttons;
        private readonly List<string> _strings;

        private const string _joker = @"../../Resources\joker.png";


        public GameScreen(Settings settings, DataBase dataBase, InitScreen initScreen, LoggedIn loggedIn)
        {
            _dataBase = dataBase;
            _loggedIn = loggedIn;

            _settings = settings;
            _game = new Game(_settings);

            _initScreen = initScreen;
            _images = new List<Image>();
            _buttons = new List<Button>();
            _strings = new List<string>();

            InitializeComponent();

            InitSettingsButton();
        }

        public Timer TimerAreTwo => _timerAreTwo;

        private void UpdateView()
        {
            if (_game.Started || _game.Paused || _game.AllUp || !_game.AllDown) return;
            InitWall();
            buttonReset.PerformClick();
        }

        private void InitWall()
        {
            tableLayoutPanel1.Hide();

            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();

            tableLayoutPanel1.ColumnCount = _settings.GetLevel + 2;
            tableLayoutPanel1.RowCount = _settings.GetLevel;
            float rows = 100 / (float) _settings.GetLevel;
            float cols = 100 / (float) (_settings.GetLevel + 2);

            for (int i = 0; i < _settings.GetLevel; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, rows));
            }

            for (int i = 0; i < _settings.GetLevel + 2; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, cols));
            }

            tableLayoutPanel1.Visible = true;
            tableLayoutPanel1.Show();
        }

        private void InitSettingsButton()
        {
            Image image =
                Image.FromFile(
                    @"../../Resources\Windows_Settings_app_icon.png");

            image = new Bitmap(image, new Size(image.Width / 55, image.Height / 55));

            buttonSettings.Size = new Size(image.Width + 8, image.Height + 8);

            buttonSettings.Image = image;

            buttonSettings.BackColor = Color.White;

            buttonScore.Size = new Size(buttonScore.Size.Width, image.Height + 8);

            buttonScore.Location = new Point(buttonScore.Location.X, buttonSettings.Location.Y);
        }

        private void InitScreen_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            InitWall();
            buttonReset.PerformClick();
        }

        private void Shuffle(List<string> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                (list[k], list[n]) = (list[n], list[k]);
            }
        }

        private List<string> Shuffle()
        {
            List<string> myList = new List<string>();
            string pathStatic = @"../../Resources\Hatch\pic";
            string pathFinal;
            Random random = new Random();

            if (_game.Joker == 1)
                // change last line
            {
                myList.Add(_joker);
            }

            for (int i = 0; i < _settings.GetLevel * (_settings.GetLevel + 2) / 2; i++)
            {
                pathFinal = pathStatic + "(" + random.Next(1, 83) + ").png";
                while (myList.Contains(pathFinal))
                {
                    pathFinal = pathStatic + "(" + random.Next(1, 83) + ").png";
                }

                myList.Add(pathFinal);
                myList.Add(myList[myList.Count - 1]);
            }

            for (int i = 0; i < _game.Settings.GetLevel * 3; i++)
            {
                Shuffle(myList);
            }

            return myList;
        }

        private void ClosingEvent(object sender, CancelEventArgs e)
        {
            _initScreen.Show();
        }

        private void Finished()
        {
            _game.FirstUp = false;
            _game.Moves++;
            buttonStop.PerformClick();
            _dataBase.UpdateScores(_loggedIn.Login, _settings, _game);
            MessageBox.Show(@"SUCCESS!! You can check your score in Top Scores", @"SUCCESS", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            buttonReset.PerformClick();
        }

        private void Joker(Button imgControl)
        {
            SetIm(imgControl);
        }

        private void Rendering(Button imgControl)
        {
            if (imgControl.BackgroundImage == null)
            {
                SetIm(imgControl);
            } else
            {
                imgControl.BackgroundImage = null;
            }
        }

        private void Started(Button imgControl)
        {
            if (imgControl.BackgroundImage == null)
            {
                if (_game.Started && !_game.FirstUp)
                {
                    _game.FirstUp = true;
                    _game.FirstButton = imgControl;
                    _game.FirstString = _strings[tableLayoutPanel1.Controls.IndexOf(imgControl)];
                    SetIm(imgControl);
                } else if (_game.Started && _game.FirstUp && !_game.SecondUp)
                {
                    _game.SecondUp = true;
                    _game.SecondButton = imgControl;
                    _game.SecondString = _strings[tableLayoutPanel1.Controls.IndexOf(imgControl)];
                    SetIm(imgControl);

                    if (_game.FirstString == _game.SecondString)
                    {
                        _game.Matched += 2;
                        if (_game.Matched + _game.Joker == _game.Settings.GetLevel * (_game.Settings.GetLevel + 2))
                        {
                            _game.Matched /= 2;
                            _game.EvalScore();
                            Finished();
                        }

                        TriggerTwoOn();
                    } else
                    {
                        _timerAreTwo.Enabled = true;
                    }
                }
            }
        }

        private void LabelsClear()
        {
            labelMoves_int.Text = 0.ToString();
            labelWrongMoves_int.Text = 0.ToString();
            labelScore_int.Text = 0.ToString();
            labelTimer.Text = 0 + @"s";
        }

        private void SpawnButtons()
        {
            foreach (var str in Shuffle())
            {
                _strings.Add(str);
                var imgControl = new Button();

                if (str == _joker)
                {
                    imgControl.Click += (sender, args) => { Joker(imgControl); };
                } else
                {
                    imgControl.Click += ImgControlOnClick;
                }

                tableLayoutPanel1.Controls.Add(imgControl);
                tableLayoutPanel1.Controls[tableLayoutPanel1.Controls.Count - 1].Anchor =
                    AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

                _images.Add(Image.FromFile(str));
                _buttons.Add(imgControl);
            }

            tableLayoutPanel1.Show();
        }

        private void SetIm(Button imgControl)
        {
            imgControl.BackgroundImage = _images[tableLayoutPanel1.Controls.IndexOf(imgControl)];
            imgControl.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void ImgControlOnClick(object sender, EventArgs e)
        {
            if (_strings[tableLayoutPanel1.Controls.IndexOf(((Button) sender))] == _joker)
            {
                Joker(((Button) sender));
            } else if (_game.Rendering)
            {
                Rendering(((Button) sender));
            } else if (_game.Started)
            {
                Started(((Button) sender));
            }
        }

        private void TimerAreTwoOnElapsed(object sender, ElapsedEventArgs e)
        {
            if (_game.FirstButton != null && _game.SecondButton != null)
            {
                if (_game.FirstString != _game.SecondString)
                {
                    _game.Mistakes++;
                    _game.Moves++;

                    _game.FirstButton.BackgroundImage = null;
                    _game.SecondButton.BackgroundImage = null;

                    _game.FirstUp = false;
                    _game.SecondUp = false;

                    _game.FirstButton = null;
                    _game.SecondButton = null;

                    _timerAreTwo.Enabled = false;
                } else if (_game.FirstString == _game.SecondString)
                {
                    _game.Moves++;

                    _game.FirstUp = false;
                    _game.SecondUp = false;

                    _game.FirstButton = null;
                    _game.SecondButton = null;
                }
            }
        }

        private void TriggerTwoOn()
        {
            _game.Moves++;

            _game.FirstUp = false;
            _game.SecondUp = false;

            _game.FirstButton = null;
            _game.SecondButton = null;
        }

        private void buttonLogout_Paint(object sender, PaintEventArgs e)
        {
            Font myFont = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            Brush myBrush = new SolidBrush(Color.Black);

            e.Graphics.TranslateTransform(12, 115);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString("LOGOUT", myFont, myBrush, 0, 0);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            _settingsScreen = new SettingsScreen(_settings, _game, _dataBase, this, _loggedIn);
            _settingsScreen.Show();
            timerSettingsScreen.Enabled = true;
            Hide();
        }

        private void buttonScore_Click(object sender, EventArgs e)
        {
            _scoresScreen = new ScoresScreen(_dataBase, _loggedIn);
            _scoresScreen.Show();
            timerScoreScreen.Enabled = true;
            Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (!_game.Started)
            {
                Close();
            } else
            {
                MessageBox.Show(@"CANT LOGOUT DURING THE GAME", @"LOGOUT DENIED", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (_game.Paused)
            {
                _game.Paused = false;
                _game.Started = true;
                _timerAreTwo.Enabled = true;
                timerClock.Enabled = true;
                timerClockScore.Enabled = true;
            } else if (!_game.Started && !_game.AllUp && _game.AllDown)
            {
                _game.Started = true;
                _game.Paused = false;
                _game.Time = 0;
                timerClock.Enabled = true;
                timerClockScore.Enabled = true;

                _timerAreTwo = new Timer(_game.Settings.Visib * 1000);
                _timerAreTwo.Elapsed += TimerAreTwoOnElapsed;
            } else
            {
                MessageBox.Show(@"CANT START NOW", @"GAME START DENIED", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (_game.Started && !_game.FirstUp)
            {
                _game.Started = false;
                _game.Paused = true;
                _timerAreTwo.Enabled = false;
                timerClock.Enabled = false;
                timerClockScore.Enabled = false;
            } else if (_game.FirstUp)
            {
                MessageBox.Show(@"CANT STOP, CARD IS UP", @"STOP DENIED", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            } else if (!_game.Started)
            {
                MessageBox.Show(@"CANT STOP GAME IS NOT RUNNING", @"STOP DENIED", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (_game.AllUp)
            {
                MessageBox.Show(@"CANT RESET DURING SHOW UP", @"RESET DENIED", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (_game.Started)
            {
                MessageBox.Show(@"CANT RESET - GAME IS RUNNING (STOP IT IF U WANT TO RESET)", @"RESET DENIED",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            tableLayoutPanel1.Hide();
            tableLayoutPanel1.Controls.Clear();
            _buttons.Clear();
            _images.Clear();
            _strings.Clear();
            LabelsClear();
            _game = new Game(_settings);

            SpawnButtons();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (!_game.Seen && !_game.Started && !_game.Paused)
            {
                _game.Rendering = true;

                _game.Time = _game.Settings.ShowVisib;

                foreach (var button in _buttons)
                {
                    button.PerformClick();
                }

                _game.Seen = true;
                _game.AllUp = true;
                _game.AllDown = false;

                timerShow.Enabled = true;

                _game.Rendering = false;
            } else
            {
                MessageBox.Show(@"CANT SHOW CARDS! PROBABLY U HAVE ALREADY SEEN THE CARDS OR GAME IS STARTED", @"SHOW DENIED", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            if (_game.AllUp && !_game.AllDown && _game.Seen)
            {
                _game.Rendering = true;

                timerShow.Enabled = false;

                foreach (var button in _buttons)
                {
                    button.PerformClick();
                }

                _game.AllUp = false;
                _game.AllDown = true;
                labelTimer.Text = @"0s";

                _game.Rendering = false;
            } else
            {
                MessageBox.Show(@"CANT HIDE CARDS! PROBABLY U HAVE ALREADY SEEN THE CARDS, THEY ARE MAYBE ALL DOWN, OR GAME IS RUNNING", @"HIDE DENIED", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void timerClockScore_Elapsed(object sender, ElapsedEventArgs e)
        {
            _game.EvalScore();
            labelScore_int.Text = _game.Score.ToString(CultureInfo.InvariantCulture);
        }

        private void timerClock_Elapsed(object sender, ElapsedEventArgs e)
        {
            labelTimer.Text = _game.Time + @"s";
            labelMoves_int.Text = _game.Moves.ToString();
            labelWrongMoves_int.Text = _game.Mistakes.ToString();
            _game.Time++;
        }

        private void timerShow_Elapsed(object sender, ElapsedEventArgs e)
        {
            labelTimer.Text = _game.Time - 1 + @"s";
            _game.Time--;

            if (_game.Time <= 0)
            {
                timerShow.Enabled = false;
                buttonHide.PerformClick();
            }
        }

        private void timerSettingsScreen_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_settingsScreen.Visible == false)
            {
                timerSettingsScreen.Enabled = false;
                Show();
                if (!_game.Seen)
                {
                    UpdateView();
                }
            }
        }

        private void timerScoreScreen_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_scoresScreen.Visible == false)
            {
                timerScoreScreen.Enabled = false;
                Show();
                if (!_game.Seen)
                {
                    UpdateView();
                }
            }
        }

        private void GameScreen_ResizeBegin(object sender, EventArgs e)
        {
            tableLayoutPanel1.Hide();
        }

        private void GameScreen_ResizeEnd(object sender, EventArgs e)
        {
            tableLayoutPanel1.Show();
        }
    }
}