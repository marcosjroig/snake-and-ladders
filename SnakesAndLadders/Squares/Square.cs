using SnakesAndLadders.Players;
using System;
using System.Collections.Generic;

namespace SnakesAndLadders.Squares
{
    public class Square : ISquare
    {
        public int Position { get; set; }
        public List<IPlayer> Players { get; set; }
        public event EventHandler<SquareEventArg> PositionChanged;
        
        public Square(List<IPlayer> players)
        {
            Players = players;
        }

        public virtual void OnPlayerLanded(IPlayer player)
        {
            Players.Add(player);
        }

        public void RemovePlayer(IPlayer player)
        {
            Players.Remove(player);
        }

        protected void OnPositionChanged(IPlayer player, int oldPosition)
        {
            PositionChanged?.Invoke(this, new SquareEventArg { Player = player, OldPosition = oldPosition});
        }
    }
}
