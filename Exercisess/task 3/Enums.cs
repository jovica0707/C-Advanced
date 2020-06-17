using System;
using System.Collections.Generic;
using System.Text;

namespace task_3
{
    public enum MenuOption
    {
        Play,
        Stats,
        Exit
    }

    public enum GameMove
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2,
    }

    public enum GameResult
    {
        FirstWin,
        SecondWin,
        Tie
    }
}
