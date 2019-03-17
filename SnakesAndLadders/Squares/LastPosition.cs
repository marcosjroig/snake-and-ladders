using System;
using SnakesAndLadders.Players;
using System.Collections.Generic;

namespace SnakesAndLadders.Squares
{
    public class LastPosition : Square
    {
        public bool HasAWinner { get; set; }

        public LastPosition(List<IPlayer> players) : base(players)
        {
        }

        public override void OnPlayerLanded(IPlayer player)
        {
            base.OnPlayerLanded(player);
            LastPositionMessage(player);
            HasAWinner = true;
        }

        private void LastPositionMessage(IPlayer player)
        {
            if (player != null)
            {
                Console.WriteLine(string.Empty);
                var message = $"--> {player.Name} Win!";
                Console.WriteLine(message);
            }
        }
    }
}
