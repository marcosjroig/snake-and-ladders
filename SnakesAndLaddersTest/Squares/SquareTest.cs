using SnakesAndLadders.Dice;
using SnakesAndLadders.Players;
using SnakesAndLadders.Squares;
using System.Collections.Generic;
using Xunit;

namespace SnakesAndLaddersTest.Squares
{
    public class SquareTest
    {
        private readonly IPlayer _player;
        private readonly List<IPlayer> _players;

        public SquareTest()
        {
            var die = new Die();
            _player = new Player(die, 100) { Name = "Player1", CurrentPosition = 8 };
            _players = new List<IPlayer>();
        }

        [Fact]
        public void OnPlayerLanded_WhenCalled_AssignThenPlayerToTheSquare()
        {
            //Arrange
            var square = new Square(_players) {Position = 8};

            //Act
            square.OnPlayerLanded(_player);

            //Test
            Assert.Single(square.Players);
        }

        [Fact]
        public void RemovePlayer_WhenCalled_RemoveThePlayerFromThatSquare()
        {
            //Arrange
            _players.Add(_player);
            var square = new Square(_players) { Position = 8 };

            //Act
            square.RemovePlayer(_player);

            //Test
            Assert.Empty(square.Players);
        }
    }
}
