using System;
using System.Collections.Generic;
using System.Text;

namespace task_3
{
    class Methods
    {
        public static MenuOption ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to rock, paper scisors");
            Console.WriteLine("1) Play");
            Console.WriteLine("2) Stats");
            Console.WriteLine("3) Exit");

            string option = Console.ReadLine();
            if (option == "1")
            {
                return MenuOption.Play;
            }
            if (option == "2")
            {
                return MenuOption.Stats;
            }
            if (option == "3")
            {
                return MenuOption.Exit;
            }
            return ShowMenu();
        }

        public static GameMove GetPlayerMove()
        {
            Console.Clear();
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");

            string move = Console.ReadLine();
            if (move == "1")
            {
                return GameMove.Rock;
            }
            if (move == "2")
            {
                return GameMove.Paper;
            }
            if (move == "3")
            {
                return GameMove.Scissors;
            }

            return GetPlayerMove();
        }

        public static GameMove GetComputerMove()
        {
            Random num = new Random();
            return (GameMove)num.Next(3);
        }

        public static void ShowGame(Game game)
        {
            GameMove computerMove = GetComputerMove();
            GameMove playerMove = GetPlayerMove();

            Console.WriteLine($"You chose {playerMove}");
            Console.WriteLine($"The computer chose {computerMove}");

            GameResult gameResult = game.Evaluate(playerMove, computerMove);

            switch (gameResult)
            {
                case GameResult.FirstWin:
                    Console.WriteLine("You won!!");
                    break;
                case GameResult.SecondWin:
                    Console.WriteLine("Computer Won");
                    break;
                case GameResult.Tie:
                    Console.WriteLine("Tie!!");
                    break;
            }

            game.RegisterResult(gameResult);
            Console.ReadLine();
        }

        public static void ShowStats(Game game)
        {
            if (game.TotalGames == 0)
            {
                Console.WriteLine("Sorry, atleaset one game needs to be played in order to view statistics");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"You have played a total of {game.TotalGames} games");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Player Wins:   {game.FirstWins}");
            Console.WriteLine($"Computer Wins: {game.SecondWins}");
            Console.WriteLine($"Ties:          {game.Ties}");
            Console.WriteLine("----------------------------------------");
            double winpct = game.FirstWins / game.WonGames * 100;
            double losepct = game.SecondWins / game.WonGames * 100;
            Console.WriteLine($"Player Win  percentage: {winpct}");
            Console.WriteLine($"Player Lose percentage: {losepct}");
            Console.WriteLine("----------------------------------------");
            Console.ReadLine();
        }
    }
}
