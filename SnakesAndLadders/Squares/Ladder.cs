using SnakesAndLadders.Players;
using System.Collections.Generic;

namespace SnakesAndLadders.Squares
{
    public class Ladder: Square
    {
        public int ClimbPosition { get; set; }

        public Ladder(List<IPlayer> players) : base(players)
        {
        }

        public override void OnPlayerLanded(IPlayer player)
        {
            var oldPosition = player.CurrentPosition;
            player.CurrentPosition = ClimbPosition;
            OnPositionChanged(player, oldPosition);
        }
    }
}
