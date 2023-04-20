using System.Collections.Generic;
using System.Windows.Forms;

namespace MemoryGame.Classes
{
    public class Game
    {

        public Game(Settings settings)
        {
            Started = false;
            Paused = false;
            Rendering = false;

            FirstUp = false;
            SecondUp = false;
            FirstButton = null;
            SecondButton = null;
            FirstString = "";
            SecondString = "";

            AllDown = true;
            AllUp = false;
            Seen = false;

            Time = 0;
            Mistakes = 0;
            Moves = 0;
            Matched = 0;
            Settings = settings;

            Visibility = new List<int>();

            Joker = Settings.GetLevel % 2 ==1 ? 1 : 0;

            Score = 0;
        }

        public string FirstString { get; set; }

        public string SecondString { get; set; }

        public Button FirstButton { get; set; }

        public Button SecondButton { get; set; }

        public bool Started { get; set; }

        public bool Rendering { get; set; }

        public bool Paused { get; set; }

        public bool FirstUp { get; set; }

        public bool SecondUp { get; set; }

        public bool AllUp { get; set; }

        public bool AllDown { get; set; }

        public int Matched { get; set; }

        public bool Seen { get; set; }

        public int Time { get; set; }

        public int Mistakes { get; set; }

        public int Joker { get; }

        public int Moves { get; set; }

        public double Score { get; private set; }

        public Settings Settings { get; }

        public List<int> Visibility { get; }

        public void EvalScore()
        {
            if (Time == 0) return;
            
            Score = 200 * (Matched + Joker) / (double)Time - 50 * Mistakes / (double)Time;
            Score *= 50;
            if (Score < 0)
            {
                Score = 0;
            }
        }
    }
}