using System;
using System.ComponentModel.DataAnnotations;

namespace LuckySteps
{
    internal class User : IUser
    {
        [Required][MaxLength(20)]
        public string FirstName { get; }
        [Required][MaxLength(20)]
        public string LastName { get; }
        [Required] [Range(1,100)]
        public int Age { get; }
        [Required][MaxLength(15)]
        public string UserName { get; }

        public int GamesCountPerDay { get; set; }
        public DateTime DateOfLastGame { get; set; }
        public int Balance { get; set; }

        public User(string firstName, string lastName, int age, string userName)
        {
            FirstName = firstName;
            LastName = lastName;    
            Age = age;  
            UserName = userName;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} Date of Last Game - {DateOfLastGame}";
        }
    }
}
