namespace MemoryGame
{
    public class LoggedIn
    {
        public LoggedIn(bool isLoggedIn, string login)
        {
            IsLoggedIn = isLoggedIn;
            Login = login;
        }

        public bool IsLoggedIn { get; }

        public string Login { get; }
    }
}