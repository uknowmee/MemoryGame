using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace MemoryGame.Classes
{
    public class DataBase
    {
        private readonly string _path;
        private const string PathUsers = @"DbUsers.json";
        private const string PathSettings = @"DbSettings.json";
        private const string PathScores = @"DbScores.json";

        private List<DbUsers> _users;
        private List<DbSettings> _settings;
        private List<DbScores> _scores;

        private class DbUsers
        {
            public string Login { get; set; }

            public string Password { get; set;}

            public DbUsers(string login, string password)
            {
                Login = login;
                Password = password;
            }
        }

        private class DbSettings
        {
            public Settings Settings { get; set;}

            public string Login { get; set;}

            public DbSettings(string login, Settings settings)
            {
                Login = login;
                Settings = settings;
            }
        }

        public class DbScores
        {
            private readonly string _login;
            private bool _personBest;

            private readonly double _score;

            public DbScores(string login, bool personBest, bool seen, int time, int mistakes, int moves, int matched,
                double score, Settings.Level level, int visib, List<int> visibility, int initVisib)
            {
                _login = login;
                _personBest = personBest;
                Seen = seen;
                Time = time;
                Mistakes = mistakes;
                Moves = moves;
                Matched = matched;
                _score = score;
                Level = level;
                Visib = visib;
                Visibility = visibility;
                InitVisib = initVisib;
            }

            public override string ToString()
            {
                StringBuilder stringBuilder = new StringBuilder();

                if (Visibility != null)
                {
                    if (Visibility.Count != 0)
                    {
                        for (int i = 0; i < Visibility.Count; i++)
                        {
                            if (i == 0)
                            {
                                stringBuilder.Append(Visibility[i]);
                            } else
                            {
                                stringBuilder.Append(", " + Visibility[i]);
                            }
                        }
                    }
                } else
                {
                    stringBuilder = new StringBuilder("NONE");
                }

                return $"{_login}\r\n" +
                       $"\tPERSON BEST: {_personBest}\r\n" +
                       $"\tSEEN: {Seen}\r\n" +
                       $"\tTIME: {Time}\r\n" +
                       $"\tMISTAKES: {Mistakes}\r\n" +
                       $"\tMOVES: {Moves}\r\n" +
                       $"\tMATCHED: {Matched}\r\n" +
                       $"\tSCORE: {(float)System.Math.Round(_score,3)}\r\n" +
                       $"\tLEVEL: {Level}\r\n" +
                       $"\tLAST FAIL HIDE TIME: {Visib}\r\n" +
                       $"\tANY FAIL HIDE TIMES: {stringBuilder}\r\n" +
                       $"\tINITIAL VISIBILITY: {InitVisib}\r\n";
            }

            public bool PersonBest
            {
                get => _personBest;
                set => _personBest = value;
            }

            public string Login => _login;

            public bool Seen { get; set; }

            public int Time { get; set;}

            public int Mistakes { get; set;}

            public int Moves { get; set;}

            public int Matched { get; set;}

            public Settings.Level Level { get; set;}

            public int Visib { get; set;}

            public List<int> Visibility { get; set;}

            public int InitVisib { get; set;}

            public double Score => _score;
        }

        public List<DbScores> Scores => _scores;

        public DataBase(string path)
        {
            _path = path;
            _users = new List<DbUsers>();
            _settings = new List<DbSettings>();
            _scores = new List<DbScores>();
        }

        public void Load()
        {
            if (!File.Exists(_path + PathUsers)) File.CreateText(_path + PathUsers);

            if (!File.Exists(_path + PathSettings)) File.CreateText(_path + PathSettings);

            if (!File.Exists(_path + PathScores)) File.CreateText(_path + PathScores);

            LoadUsers();
            LoadSettings();
            LoadScores();
        }

        public void Save()
        {
            if (!File.Exists(_path + PathUsers)) File.CreateText(_path + PathUsers);

            if (!File.Exists(_path + PathSettings)) File.CreateText(_path + PathSettings);

            if (!File.Exists(_path + PathScores)) File.CreateText(_path + PathScores);

            SaveUsers();
            SaveSettings();
            SaveScores();
        }

        private void LoadScores()
        {
            StreamReader streamReader = new StreamReader(_path + PathScores);
            string json = streamReader.ReadToEnd();

            List<DbScores> loadScores = JsonConvert.DeserializeObject<List<DbScores>>(json);
            if (loadScores != null)
            {
                _scores = loadScores;
            }

            streamReader.Close();
        }

        private void LoadSettings()
        {
            StreamReader streamReader = new StreamReader(_path + PathSettings);
            string json = streamReader.ReadToEnd();

            List<DbSettings> loadSettings = JsonConvert.DeserializeObject<List<DbSettings>>(json);
            if (loadSettings != null)
            {
                _settings = loadSettings;
            }

            streamReader.Close();
        }

        private void LoadUsers()
        {
            StreamReader streamReader = new StreamReader(_path + PathUsers);
            string json = streamReader.ReadToEnd();

            List<DbUsers> loadUsers = JsonConvert.DeserializeObject<List<DbUsers>>(json);
            if (loadUsers != null)
            {
                _users = loadUsers;
            }

            streamReader.Close();
        }

        private void SaveScores()
        {
            if (_scores.Count == 0)
            {
                return;
            }

            StreamWriter streamWriter = new StreamWriter(_path + PathScores);
            streamWriter.Write(JsonConvert.SerializeObject(_scores));
            streamWriter.Close();
        }

        private void SaveSettings()
        {
            if (_settings.Count == 0)
            {
                return;
            }

            StreamWriter streamWriter = new StreamWriter(_path + PathSettings);
            streamWriter.Write(JsonConvert.SerializeObject(_settings));
            streamWriter.Close();
        }

        private void SaveUsers()
        {
            if (_users.Count == 0)
            {
                return;
            }

            StreamWriter streamWriter = new StreamWriter(_path + PathUsers);
            streamWriter.Write(JsonConvert.SerializeObject(_users));
            streamWriter.Close();
        }

        public void UpdateUsers(string login, string password)
        {
            UpdateSettings(login, new Settings());
            _users.Add(new DbUsers(login, password));
            SaveUsers();
        }

        public void UpdateSettings(string login, Settings settings)
        {
            if (_users == null)
            {
                _settings.Add(new DbSettings(login, settings));
                return;
            }

            if (_users.All(user => user.Login != login))
            {
                _settings.Add(new DbSettings(login, settings));
            } else
            {
                foreach (var setting in _settings.Where(setting => setting.Login == login))
                {
                    setting.Settings.SetAs(settings);
                }
            }

            SaveSettings();
        }

        public void UpdateScores(string login, Settings settings, Game game)
        {
            bool isPersonBest = IsPersonBest(game, login);

            if (!isPersonBest)
            {
                ScoresAdd(login, false, game);
            } else
            {
                foreach (var score in _scores.Where(score => score.PersonBest && score.Login == login))
                {
                    score.PersonBest = false;
                }

                ScoresAdd(login, true, game);
            }

            SaveScores();
        }

        private void ScoresAdd(string login, bool isPersonBest, Game game)
        {
            Settings.Level level = (Settings.Level) game.Settings.GetLevel;
            _scores.Add(new DbScores(login, isPersonBest, game.Seen, game.Time, game.Mistakes, game.Moves,
                game.Matched, game.Score, level, game.Settings.Visib, game.Visibility, game.Settings.ShowVisib));
        }

        private bool IsPersonBest(Game game, string login)
        {
            if (_scores == null)
            {
                return true;
            }

            if (_scores.All(score => score.Login != login))
            {
                return true;
            }

            double value = (from score in _scores where score.Login == login select score.Score).Prepend(-1000000000)
                .Max();

            return !(value > game.Score);
        }

        public void SetGameUserNameSettings(string username, Settings settings)
        {
            foreach (var setting in _settings)
            {
                if (setting.Login == username)
                {
                    settings.SetAs(setting.Settings);
                }

                break;
            }
        }

        public bool IfUserExist(string username, string password)
        {
            if (_users.Count == 0)
            {
                return false;
            }

            return _users.Count != 0 && _users.Any(user => user.Login == username && user.Password == password);
        }

        public bool IfUserNameExist(string username)
        {
            return _users.Count != 0 && _users.Any(user => user.Login == username);
        }
    }
}