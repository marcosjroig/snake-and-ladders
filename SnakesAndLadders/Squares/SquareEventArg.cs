using SnakesAndLadders.Players;
using System;

namespace SnakesAndLadders.Squares
{
    public class SquareEventArg : EventArgs
    {
        public IPlayer Player { get; set; }
        public int OldPosition { get; set; }
    }
}
