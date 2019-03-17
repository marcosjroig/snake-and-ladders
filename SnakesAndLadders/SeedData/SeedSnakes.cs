using SnakesAndLadders.Players;
using SnakesAndLadders.Squares;
using System.Collections.Generic;

namespace SnakesAndLadders.SeedData
{
    public class SeedSnakes
    {
        public static void CreateSnakes(List<ISquare> board)
        {
            board[21] = new Snake(new List<IPlayer>()) { Position = 22, BackPosition = 2 };
            board[27] = new Snake(new List<IPlayer>()) { Position = 28, BackPosition = 6 };
            board[29] = new Snake(new List<IPlayer>()) { Position = 30, BackPosition = 10 };
            board[43] = new Snake(new List<IPlayer>()) { Position = 44, BackPosition = 26 };
            board[57] = new Snake(new List<IPlayer>()) { Position = 58, BackPosition = 42 };
            board[65] = new Snake(new List<IPlayer>()) { Position = 66, BackPosition = 14 };
            board[67] = new Snake(new List<IPlayer>()) { Position = 68, BackPosition = 52 };
            board[71] = new Snake(new List<IPlayer>()) { Position = 72, BackPosition = 50 };
            board[83] = new Snake(new List<IPlayer>()) { Position = 84, BackPosition = 62 };
            board[93] = new Snake(new List<IPlayer>()) { Position = 94, BackPosition = 64 };
            board[95] = new Snake(new List<IPlayer>()) { Position = 96, BackPosition = 82 };
            board[97] = new Snake(new List<IPlayer>()) { Position = 98, BackPosition = 78 };
        }
    }
}
