using SnakesAndLadders.Players;

namespace SnakesAndLadders.GameSetup
{
    public interface IPlayMessage
    {
        void PlayerLandedMessage(IPlayer player);
        void PlayerMovedMessage(IPlayer player, int oldPosition);
    }
}
