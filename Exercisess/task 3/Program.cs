using System;

namespace task_3
{
    class Program
    {

        static void Main(string[] args)
        {
            var game = new Game();
            while (true)
            {
                var playerChoice = Methods.ShowMenu();
                switch (playerChoice)
                {
                    case MenuOption.Play:
                        Methods.ShowGame(game);
                        break;
                    case MenuOption.Stats:
                        Methods.ShowStats(game);
                        break;
                    case MenuOption.Exit:
                        Console.WriteLine("Bye");
                        return;
                }
            }
        }
    }

}
