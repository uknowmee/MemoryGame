using System;
using System.Windows.Forms;
using MemoryGame.Classes;

namespace MemoryGame
{
    public partial class RegisterScreen : Form
    {
        private readonly DataBase _dataBase;

        public RegisterScreen(DataBase dataBase)
        {
            _dataBase = dataBase;

            InitializeComponent();
        }

        private void RegisterScreen_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text =="" || textBoxPassword.Text == "" || textBoxPassword_2.Text =="")
            {
                MessageBox.Show(@"LOGIN / PASSWORD CANT BE EMPTY", @"DEFINE YOURSELF", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (textBoxPassword.Text != textBoxPassword_2.Text)
            {
                MessageBox.Show(@"TYPE SAME PASSWORD X2", @"WRONG PASSWORD", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            
            if (!_dataBase.IfUserNameExist(textBoxLogin.Text))
            {
                _dataBase.UpdateUsers(textBoxLogin.Text, textBoxPassword.Text);
                _dataBase.Save();
                Close();
            } else
            {
                MessageBox.Show(@"LOGIN IS TAKEN, choose another one", @"TAKEN LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text =="")
            {
                MessageBox.Show(@"LOGIN / PASSWORD CANT BE EMPTY", @"DEFINE YOURSELF", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (!_dataBase.IfUserNameExist(textBoxLogin.Text))
            {
                MessageBox.Show(@"you can use ur login", @"CORRECT LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show(@"LOGIN IS TAKEN, choose another one", @"TAKEN LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void buttonQuit_Click_1(object sender, EventArgs e)
        {
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            textBoxPassword_2.Text = "";
            Close();
        }
    }
}