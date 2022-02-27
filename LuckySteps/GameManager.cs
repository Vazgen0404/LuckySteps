using System.Collections.Generic;

namespace LuckySteps
{
    internal static class GameManager
    {
        public static Dictionary<string,IUser> Users { get; set; }
        public static Dictionary<string,IGame> WiningGames { get; set; }

        static GameManager()
        {
            Users = new Dictionary<string,IUser>();
            WiningGames = new Dictionary<string,IGame>();
        }
    }
}
