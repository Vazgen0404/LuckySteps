using System;

namespace LuckySteps
{
    internal interface IUser
    {
        string FirstName { get; }
        string LastName { get; }
        int Age { get; }
        string UserName { get; }
        int GamesCountPerDay { get; set; }
        public DateTime DateOfLastGame { get; set; }
        int Balance { get; set; }
    }
}
