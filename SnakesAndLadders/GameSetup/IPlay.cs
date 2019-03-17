using SnakesAndLadders.Players;

namespace SnakesAndLadders.GameSetup
{
    public interface IPlay
    {
        IGame Game { get; set; }
        void StartGame();
        void RollDice();
        void MoveAllPlayers();
        void MovePlayer(IPlayer player);
        void RemovePlayer(IPlayer player, int initialPosition);
        void ChangePlayerPosition(IPlayer player);
        bool CheckForWinner();
    }
}
