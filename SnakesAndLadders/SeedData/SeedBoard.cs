using SnakesAndLadders.Players;
using SnakesAndLadders.Squares;
using System.Collections.Generic;
using SnakesAndLadders.GameSetup;

namespace SnakesAndLadders.SeedData
{
    public static class SeedBoard
    {
        public static Board CreateBoard(int topPosition)
        {
            var squareList = new List<ISquare>();
            
            for (int i = 0; i < topPosition; i++)
            {
                squareList.Add(new Square(new List<IPlayer>()) { Position = i + 1 });
            }

            CreateLastPosition(topPosition, squareList);
            var board = new Board(new PlayMessage(), squareList);

            return board;
        }

        private static void CreateLastPosition(int topPosition, List<ISquare> board)
        {
            var lastPostion = new LastPosition(new List<IPlayer>()) {Position = topPosition};
            board[topPosition - 1] = lastPostion;
        }
    }
}
