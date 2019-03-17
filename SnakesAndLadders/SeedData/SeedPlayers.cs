using SnakesAndLadders.Dice;
using System.Collections.Generic;
using SnakesAndLadders.Players;

namespace SnakesAndLadders.SeedData
{
    public static class SeedPlayers
    {
        public static List<IPlayer> CreatePlayers(int topPosition)
        {
            var players = new List<IPlayer>
            {
                new Player(new Die(), topPosition) {Name = "Player1", CurrentPosition = 1},
                new Player(new Die(), topPosition) {Name = "Player2", CurrentPosition = 1}
            };

            return players;
        }
    }
}
