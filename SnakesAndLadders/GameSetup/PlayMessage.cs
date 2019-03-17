using SnakesAndLadders.Players;
using System;

namespace SnakesAndLadders.GameSetup
{
    public class PlayMessage: IPlayMessage
    {
        public string Message { get; set; }

        public void PlayerLandedMessage(IPlayer player)
        {
            if (player != null)
            {
                Message = $"--> {player.Name} landed at position: {player.CurrentPosition}";
                Console.WriteLine(Message);
            }
        }

        public void PlayerMovedMessage(IPlayer player, int oldPosition)
        {
            if (player != null)
            {
                var squareType = SnakeOrLadder(oldPosition, player.CurrentPosition);

                Message = $"--> {player.Name} has found a {squareType} and will be moved to position: {player.CurrentPosition}";

                Console.WriteLine(Message);
            }
        }

        private string SnakeOrLadder(int landedPosition, int movedPosition)
        {
            if (landedPosition < movedPosition)
            {
                return "Ladder :-)";
            }

            return "Snake :-(";
        }
    }
}
