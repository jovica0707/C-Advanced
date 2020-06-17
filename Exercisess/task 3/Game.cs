using System;
using System.Collections.Generic;
using System.Text;

namespace task_3
{
    public class Game
    {
        public int TotalGames { get => FirstWins + SecondWins + Ties; }
        public int WonGames { get => FirstWins + SecondWins; }
        public int FirstWins { get; private set; } = 0;
        public int SecondWins { get; private set; } = 0;
        public int Ties { get; private set; } = 0;

        public Game()
        {

        }

        internal GameResult Evaluate(GameMove first, GameMove second)
        {
            if (first == second)
            {
                return GameResult.Tie;
            }

            if (first == GameMove.Rock)
            {
                if (second == GameMove.Scissors)
                {
                    return GameResult.FirstWin;
                }
                return GameResult.SecondWin;
            }

            if (first == GameMove.Paper)
            {
                if (second == GameMove.Rock)
                {
                    return GameResult.FirstWin;
                }
                return GameResult.SecondWin;
            }

            if (first == GameMove.Scissors)
            {
                if (second == GameMove.Paper)
                {
                    return GameResult.FirstWin;
                }
                return GameResult.SecondWin;
            }

            throw new ApplicationException($"The game evaluation between {first} and {second} failed");
        }

        public void RegisterResult(GameResult result)
        {
            switch (result)
            {
                case GameResult.FirstWin:
                    FirstWins++;
                    break;
                case GameResult.SecondWin:
                    SecondWins++;
                    break;
                case GameResult.Tie:
                    Ties++;
                    break;
            }
        }


    }
}
