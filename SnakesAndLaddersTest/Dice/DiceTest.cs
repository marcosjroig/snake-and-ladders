using SnakesAndLadders.Dice;
using Xunit;

namespace SnakesAndLaddersTest.Dice
{
    public class DiceTest
    {
        [Fact]
        public void Roll_WhenCalled_GenerateNumbersBetweenOneAndSix()
        {
            //Arrange
            var die = new Die();
            
            //Action
            var result = die.Roll();

            //Assert
            Assert.True(result >= 1 && result <= 6);
        }
    }
}
