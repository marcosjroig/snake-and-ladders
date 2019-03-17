using SnakesAndLadders.Players;
using System.Collections.Generic;

namespace SnakesAndLadders.GameSetup
{
    public interface IGame
    {
        int TopPosition { get; set; }
        List<IPlayer> Players { get; set; }
        IBoard Board { get; set; }

        void CreateGame();
        void CreatePlayers();
        void CreateBoard();
        void CreateSnakes();
        void CreateLadders();
    }
}
