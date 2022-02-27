using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LuckySteps
{
    internal class UserCreator : IUserCreator
    {
        private IUser _user;
        private List<ValidationResult> _results = new List<ValidationResult>();

        public IUser CreateUser(string userName)
        {
            InputDatas(userName);
            if (!Validate())
            {
                foreach (var result in _results)
                {
                    Console.WriteLine(result.ErrorMessage);
                }
                throw new InvalidOperationException("Invalid Input Datas");
            }
            return _user;
        }
        public void InputDatas(string userName)
        {
            Console.Write("Enter First Name - ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name - ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Age - ");
            int age = Convert.ToInt32(Console.ReadLine());

            _user = new User(firstName, lastName, age, userName);
        }

        public bool Validate()
        {
            var context = new ValidationContext(_user);
            return Validator.TryValidateObject(_user, context, _results, true);
        }
    }
}
