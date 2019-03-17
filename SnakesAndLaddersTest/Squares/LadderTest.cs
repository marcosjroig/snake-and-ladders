using Moq;
using SnakesAndLadders.Dice;
using SnakesAndLadders.Players;
using SnakesAndLadders.Squares;
using System.Collections.Generic;
using Xunit;

namespace SnakesAndLaddersTest.Squares
{
    public class LadderTest
    {
        private readonly IPlayer _player;
        private readonly List<IPlayer> _players;
        public LadderTest()
        {
            var dieMock = new Mock<IDie>();
            dieMock.Setup(x => x.Roll()).Returns(2);
            _player = new Player(dieMock.Object, 100) { CurrentPosition = 18 };
            _players = new List<IPlayer>();
        }

        [Fact]
        public void OnPlayerLanded_WhenCalled_MoveThePlayerUpSomePositions()
        {
            //Arrange
            var ladder = new Ladder(_players) { ClimbPosition = 74 };

            //Act
            ladder.OnPlayerLanded(_player);

            //Test
            Assert.Equal(74, _player.CurrentPosition);
            Assert.Empty(ladder.Players);
        }
    }
}
