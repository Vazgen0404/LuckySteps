using System;

namespace LuckySteps
{
    internal class Game : IGame
    {
        public IUser User { get; set; }
        public ITicket Ticket { get; set; }
        public int Money { get; set; }
        public Game(IUser user, ITicket ticket)
        {
            User = user;
            Ticket = ticket;
        }
        public void Start()
        {
            User.DateOfLastGame = DateTime.Now;
            User.GamesCountPerDay++;

            Console.WriteLine("Enter 1 Or 2");
            Console.WriteLine("Enter 3 to withdraw the amount"); 
            Console.WriteLine();
            for (int i = 0; i < Ticket.Steps.Length; i++)
            {
                Console.Write($"Step {i + 1} - ");
                ChoiceType choice = (ChoiceType)Convert.ToInt32(Console.ReadLine());
                if (choice == ChoiceType.Left && Ticket.Steps[i].LeftColoumn.IsEmpty ||
                    choice == ChoiceType.Right && Ticket.Steps[i].RightColoumn.IsEmpty )
                {
                    Console.WriteLine("You Lose!!!");
                    break;
                }
                else if(choice == ChoiceType.Stop)
                {
                    Console.WriteLine($"You win {Money} money");
                    Ticket.LastStepNumber = i;
                    GameManager.WiningGames.Add(User.UserName, this);
                    break;
                }
                else
                {
                    Money = Ticket.Steps[i].Money;
                    Console.WriteLine($"True. You win {Money} money");
                }

                if (i == Ticket.Steps.Length - 1)
                {
                    Console.WriteLine("Finish");
                    GameManager.WiningGames.Add(User.UserName, this);
                }
            }
        }
        public override string ToString()
        {
            return $"Username - {User.UserName}  Step Number - {Ticket.LastStepNumber}  Money - {Money}";
        }
    }
}
