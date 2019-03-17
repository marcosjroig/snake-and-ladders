using SnakesAndLadders.Players;
using SnakesAndLadders.Squares;
using System.Collections.Generic;

namespace SnakesAndLadders.SeedData
{
    public static class SeedLadders
    {
        public static void CreateLadders(List<ISquare> board)
        {
            board[3] = new Ladder(new List<IPlayer>()) { Position = 4, ClimbPosition = 16 };
            board[7] = new Ladder(new List<IPlayer>()) { Position = 8, ClimbPosition = 12 };
            board[17] = new Ladder(new List<IPlayer>()) { Position = 18, ClimbPosition = 38 };
            board[19] = new Ladder(new List<IPlayer>()) { Position = 20, ClimbPosition = 74 };
            board[23] = new Ladder(new List<IPlayer>()) { Position = 24, ClimbPosition = 36 };
            board[31] = new Ladder(new List<IPlayer>()) { Position = 32, ClimbPosition = 56 };
            board[33] = new Ladder(new List<IPlayer>()) { Position = 34, ClimbPosition = 46 };
            board[39] = new Ladder(new List<IPlayer>()) { Position = 40, ClimbPosition = 60 };
            board[47] = new Ladder(new List<IPlayer>()) { Position = 48, ClimbPosition = 54 };
            board[69] = new Ladder(new List<IPlayer>()) { Position = 70, ClimbPosition = 88 };
            board[75] = new Ladder(new List<IPlayer>()) { Position = 76, ClimbPosition = 86 };
            board[79] = new Ladder(new List<IPlayer>()) { Position = 80, ClimbPosition = 100 };
            board[89] = new Ladder(new List<IPlayer>()) { Position = 90, ClimbPosition = 92 };
        }
    }
}
