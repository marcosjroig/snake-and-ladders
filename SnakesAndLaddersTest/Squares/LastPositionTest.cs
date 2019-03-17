using SnakesAndLadders.Dice;
using SnakesAndLadders.Players;
using SnakesAndLadders.Squares;
using System.Collections.Generic;
using Xunit;

namespace SnakesAndLaddersTest.Squares
{
    public class LastPositionTest
    {
        [Fact]
        public void OnPlayerLanded_WhenCalled_SetTheWinnerVariableToTrue()
        {
            //Arrange
            var player = new Player(new Die(), 100) { CurrentPosition = 100 };
            var lastPostion = new LastPosition(new List<IPlayer>());

            //Act
            lastPostion.OnPlayerLanded(player);

            //Assert
            Assert.True(lastPostion.HasAWinner);
            Assert.Single(lastPostion.Players);
        }
    }
}
