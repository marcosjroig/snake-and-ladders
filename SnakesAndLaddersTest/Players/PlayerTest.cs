using Moq;
using SnakesAndLadders.Dice;
using SnakesAndLadders.Players;
using Xunit;

namespace SnakesAndLaddersTest.Players
{
    public class PlayerTest
    {
        private readonly Mock<IDie> _dieMock;
        public PlayerTest()
        {
            _dieMock = new Mock<IDie>();
            _dieMock.Setup(x => x.Roll()).Returns(4);
        }

        [Fact]
        public void Move_WhenCalled_IncreaseThePlayerPosition()
        {
            //Arrange
            var player = new Player(_dieMock.Object, 100) {CurrentPosition = 1};

            //Act
            player.Move();

            //Assert
            Assert.Equal(5, player.CurrentPosition);
        }

        [Fact]
        public void Move_WithNewPositionOutsideOfTheBoard_DoesNotChangePlayerPosition()
        {
            //Arrange
            var player = new Player(_dieMock.Object, 100) { CurrentPosition = 99 };

            //Act
            player.Move(); // 99 + 4

            //Assert
            Assert.Equal(99, player.CurrentPosition);
        }
    }
}
