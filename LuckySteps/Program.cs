using System;

namespace LuckySteps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMainMenu();
        }
        public static void ShowMainMenu()
        {
            while (true)
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine("1.  Start New Game");                 
                    Console.WriteLine("2.  Show Winners");
                    Console.WriteLine("3.  Information About Users");
                    Console.WriteLine();
                    Console.WriteLine("    Please select a number for the menu options ");

                    int input = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    switch (input)
                    {
                        case 1:
                            StartNewGame();
                            break;
                        case 2:
                            ShowWinners();
                            break;
                        case 3:
                            InformationAboutUsers();
                            break;
                        default:
                            throw new Exception("Please enter the correct number");
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
                finally
                {
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
            }
        }

        private static void InformationAboutUsers()
        {
            foreach (var user in GameManager.Users.Values)
            {
                Console.WriteLine(user.ToString());
            }
        }

        private static void ShowWinners()
        {
            foreach (var game in GameManager.WiningGames.Values)
            {
                Console.WriteLine(game.ToString());
            }
        }

        private static void StartNewGame()
        {
            Console.Write("Enter Username - ");
            IGame game = new GameCreator().CreateGame(Console.ReadLine());
            Console.Clear();
            game.Start();
        }
    }
}
