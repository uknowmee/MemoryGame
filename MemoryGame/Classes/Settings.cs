using System.Windows.Forms;

namespace MemoryGame.Classes
{
    public class Settings
    {
        private Level _level;
        private int _showVisib;

        private readonly int _minShowVisib = 20;
        private readonly int _maxShowVisib = 60;
        private readonly int _diffShowVisib = 5;

        private readonly int _minVisib = 1;
        private readonly int _maxVisib = 10;
        private readonly int _diffVisib = 1;

        public enum Level
        {
            Pro = 10,
            Hard = 9,
            Normal = 8,
            Easy = 5,
            Demo = 4
            // remember to change game constructor joker's if 
        }

        public Settings()
        {
            _level = Level.Demo;
            _showVisib = _minShowVisib;
            Visib = _minVisib;
        }

        public Settings(Settings settings)
        {
            _level = settings._level;
            Visib = settings.Visib;
            _showVisib = settings._showVisib;
        }

        public int GetLevel => (int) _level;

        public int ShowVisib => _showVisib;

        public int Visib { get; private set; }

        public void MinusLevel()
        {
            switch (_level)
            {
                case Level.Demo:
                    MessageBox.Show(@"CANT GO LOWER", @"LOW LVL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _level = Level.Pro;
                    break;
                case Level.Easy:
                    _level = Level.Demo;
                    break;
                case Level.Normal:
                    _level = Level.Easy;
                    break;
                default:
                    _level--;
                    break;
            }
        }

        public void PlusLevel()
        {
            switch (_level)
            {
                case Level.Pro:
                    MessageBox.Show(@"CANT GO HIGHER", @"HIGH LVL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _level = Level.Demo;
                    break;
                case Level.Demo:
                    _level = Level.Easy;
                    break;
                case Level.Easy:
                    _level = Level.Normal;
                    break;
                default:
                    _level++;
                    break;
            }
        }

        public void MinusVisib()
        {
            if (Visib == _minVisib)
            {
                MessageBox.Show(@"CANT GO LOWER", @"LOW VISIB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Visib = _maxVisib;
            } else
            {
                Visib -= _diffVisib;
            }
        }

        public void PlusVisib()
        {
            if (Visib == _maxVisib)
            {
                MessageBox.Show(@"CANT GO HIGHER", @"HIGH VISIB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Visib = _minVisib;
            } else
            {
                Visib += _diffVisib;
            }
        }

        public void MinusShowVisib()
        {
            if (_showVisib == _minShowVisib)
            {
                MessageBox.Show(@"CANT GO LOWER", @"LOW VISIB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _showVisib = _maxShowVisib;
            } else
            {
                _showVisib -= _diffShowVisib;
            }
        }

        public void PlusShowVisib()
        {
            if (_showVisib == _maxShowVisib)
            {
                MessageBox.Show(@"CANT GO HIGHER", @"HIGH VISIB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _showVisib = _minShowVisib;
            } else
            {
                _showVisib += _diffShowVisib;
            }
        }

        public void SetAs(Settings settings)
        {
            _level = settings._level;
            Visib = settings.Visib;
            _showVisib = settings._showVisib;
        }
    }
}