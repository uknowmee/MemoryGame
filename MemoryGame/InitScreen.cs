using System;
using System.ComponentModel;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using MemoryGame.Classes;

namespace MemoryGame
{
    public partial class InitScreen : Form
    {
        private readonly DataBase _dataBase;

        private readonly Settings _settings;
        private SettingsScreen _settingsScreen;
        private RegisterScreen _registerScreen;
        private GameScreen _gameScreen;
        private ScoresScreen _scoresScreen;

        public InitScreen()
        {
            _dataBase = new DataBase(@"../../Resources\Database\");
            _dataBase.Load();

            _settings = new Settings();

            InitializeComponent();

            InitSettingsButton();

            SetBackImage();
        }

        private void SetBackImage()
        {
            Image imageBack =
                Image.FromFile(
                    @"../../Resources\Screenshot_1.png");

            imageBack = new Bitmap(imageBack, new Size(imageBack.Width, imageBack.Height));

            BackgroundImage = imageBack;

            Image imageFace =
                Image.FromFile(
                    @"../../Resources\Untitled_design_17.png");

            imageFace = new Bitmap(imageFace, new Size(imageFace.Width, imageFace.Height));

            labelFace.SendToBack();

            labelFace.Size = new Size(imageFace.Width, imageFace.Height);

            labelFace.Image = imageFace;
        }

        private void InitScreen_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
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
        }

        private void ClosingEvent(object sender, CancelEventArgs e)
        {
            _dataBase.Save();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show(@"LOGIN / PASSWORD CANT BE EMPTY", @"DEFINE YOURSELF", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (_dataBase.IfUserExist(textBoxLogin.Text, textBoxPassword.Text))
            {
                DialogResult dialogResult = MessageBox.Show(@"Do you want to use local settings?", @"SETTINGS",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.No)
                {
                    _dataBase.SetGameUserNameSettings(textBoxLogin.Text, _settings);
                } else if (dialogResult == DialogResult.Yes)
                {
                    _dataBase.UpdateSettings(textBoxLogin.Text, _settings);
                } else
                {
                    return;
                }

                _gameScreen = new GameScreen(_settings, _dataBase, this, new LoggedIn(true, textBoxLogin.Text));
                _gameScreen.Show();
                Hide();
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
            } else
            {
                MessageBox.Show(@"wrong login or password", @"LOGIN ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            _settingsScreen = new SettingsScreen(_settings, null, _dataBase, null, new LoggedIn(false, ""));
            _settingsScreen.Show();
            timerSettings.Enabled = true;
            Hide();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            _registerScreen = new RegisterScreen(_dataBase);
            _registerScreen.Show();
            timerRegister.Enabled = true;
            Hide();
        }

        private void buttonScore_Click(object sender, EventArgs e)
        {
            _scoresScreen = new ScoresScreen(_dataBase, new LoggedIn(false, ""));
            _scoresScreen.Show();
            timerScore.Enabled = true;
            Hide();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timerSettings_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_settingsScreen.Visible == false)
            {
                timerSettings.Enabled = false;
                Show();
            }
        }

        private void timerRegister_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_registerScreen.Visible == false)
            {
                timerRegister.Enabled = false;
                Show();
            }
        }

        private void timerScore_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_scoresScreen.Visible == false)
            {
                timerScore.Enabled = false;
                Show();
            }
        }
    }
}