using SnakesAndLadders.Players;
using SnakesAndLadders.SeedData;
using System.Collections.Generic;

namespace SnakesAndLadders.GameSetup
{
    public class Game: IGame
    {
        public int TopPosition { get; set; }
        public List<IPlayer> Players { get; set; }
        public IBoard Board { get; set; }
        
        public void CreateGame()
        {
            TopPosition = 100;
            CreatePlayers();
            CreateBoard();
            CreateSnakes();
            CreateLadders();
            Board.SubscribeToSquareEvents();
        }

        public void CreatePlayers()
        {
            Players = SeedPlayers.CreatePlayers(TopPosition);
        }

        public void CreateBoard()
        {
            Board = SeedBoard.CreateBoard(TopPosition);
        }

        public void CreateSnakes()
        {
            SeedSnakes.CreateSnakes(Board.SquareList);
        }

        public void CreateLadders()
        {
            SeedLadders.CreateLadders(Board.SquareList);
        }
    }
}
