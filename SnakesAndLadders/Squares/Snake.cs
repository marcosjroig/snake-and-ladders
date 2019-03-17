using SnakesAndLadders.Players;
using System.Collections.Generic;

namespace SnakesAndLadders.Squares
{
    public class Snake : Square
    {
        public int BackPosition { get; set; }

        public Snake(List<IPlayer> players) : base(players)
        {
        }

        public override void OnPlayerLanded(IPlayer player)
        {
            var oldPosition = player.CurrentPosition;
            player.CurrentPosition = BackPosition;
            OnPositionChanged(player, oldPosition);
        }
    }
}
