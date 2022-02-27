using System;

namespace LuckySteps
{
    internal class GameCreator : IGameCreator
    {
        public IUser GetUser(string userName)
        {
            IUser user;
            if (GameManager.Users.ContainsKey(userName))
            {
                user = GameManager.Users[userName];
            }
            else
            {
                user = new UserCreator().CreateUser(userName);
                GameManager.Users.Add(userName, user);
            }
            return user;    
        }

        public IGame CreateGame(string userName)
        {
            IUser user = GetUser(userName);
            if (user.DateOfLastGame.Day == DateTime.Now.Day && user.GamesCountPerDay == 3)
            {
                throw new Exception("You can play up to 3 times a day");
            }
            else if (user.DateOfLastGame.Day != DateTime.Now.Day)
            {
                user.GamesCountPerDay = 0;
            }

            ITicket ticket = CreateAndInitializeTicket();
      
            return new Game(user, ticket);
        }

        public ITicket CreateAndInitializeTicket()
        {
            ITicket ticket = new Ticket();
            int money = 100;
            for (int i = 0; i < ticket.Steps.Length; i++)
            {
                ticket.Steps[i] = new StepCreator().CreateStep();
                ticket.Steps[i].Money = money;
                money *= 2;
            }

            return ticket;
        }
    }
}
