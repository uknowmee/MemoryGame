using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MemoryGame.Classes;

namespace MemoryGame
{
    public partial class ScoresScreen : Form
    {
        private readonly int _listOffset;
        private readonly DataBase _dataBase;
        private readonly LoggedIn _loggedIn;

        public ScoresScreen(DataBase dataBase, LoggedIn loggedIn)
        {
            _dataBase = dataBase;
            _loggedIn = loggedIn;

            InitializeComponent();

            _listOffset = 120;

            GetScore();
            
            listBoxScores.Hide();
            listBoxYourScores.Hide();
            CreateMyMultilineTextBox();
        }

        private void ScoresScreen_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void buttonQuit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void ScoresScreen_Resize(object sender, EventArgs e)
        {
            textBox1.Width = GetScoreWidth();
            textBox1.Location = new Point(80, textBox1.Location.Y);

            textBox2.Width = GetScoreWidth();
            textBox2.Location = new Point(Width / 2 + 30, textBox2.Location.Y);
        }

        private void GetScore()
        {
            string str;

            if (_dataBase.Scores.Count != 0)
            {
                var sc = new List<DataBase.DbScores>(_dataBase.Scores.OrderBy(o => -o.Score).ToList());
                
                for (int i = 0; i < _dataBase.Scores.Count; i++)
                {
                    str = sc[i].ToString();
                    textBox1.Text += i+1 + ") "+ str + "\r\n\r\n";
                }

                var score = sc.Where(scores => scores.Login == _loggedIn.Login).ToList();
            
                if (score.Count != 0)
                {
                    for (int i = 0; i < score.Count(); i++)
                    {
                        str = score[i].ToString();
                        textBox2.Text += i+1 + ") "+ str + "\r\n\r\n";
                    }
                }
            }
        }
        
        private int GetScoreWidth()
        {
            return Width / 2 - _listOffset;
        }

        private void CreateMyMultilineTextBox()
        {
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.AcceptsReturn = true;
            textBox1.AcceptsTab = true;
            textBox1.WordWrap = true;
            textBox1.ReadOnly = true;
            
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.AcceptsReturn = true;
            textBox2.AcceptsTab = true;
            textBox2.WordWrap = true;
            textBox2.ReadOnly = true;
        }
    }
}