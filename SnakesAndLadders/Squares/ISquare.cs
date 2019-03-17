using System;
using SnakesAndLadders.Players;
using System.Collections.Generic;

namespace SnakesAndLadders.Squares
{
    public interface ISquare
    {
        int Position { get; set; }
        List<IPlayer> Players { get; set; }
        event EventHandler<SquareEventArg> PositionChanged;
        void OnPlayerLanded(IPlayer player);
        void RemovePlayer(IPlayer player);
    }
}
