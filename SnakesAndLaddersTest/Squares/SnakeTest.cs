using Moq;
using SnakesAndLadders.Dice;
using SnakesAndLadders.Players;
using SnakesAndLadders.Squares;
using System.Collections.Generic;
using Xunit;

namespace SnakesAndLaddersTest.Squares
{
    public class SnakeTest
    {
        private readonly IPlayer _player;
        private readonly List<IPlayer> _players;
        public SnakeTest()
        {
            var dieMock = new Mock<IDie>();
            dieMock.Setup(x => x.Roll()).Returns(2);
            _player = new Player(dieMock.Object, 100) { CurrentPosition = 20 };
            _players = new List<IPlayer>();
        }

        [Fact]
        public void OnPlayerLanded_WhenCalled_MoveThePlayerBackSomePositions()
        {
            //Arrange
            var snake = new Snake(_players){ BackPosition = 2};

            //Act
            snake.OnPlayerLanded(_player);

            //Test
            Assert.Equal(2, _player.CurrentPosition);
            Assert.Empty(snake.Players);
        }
    }
}
