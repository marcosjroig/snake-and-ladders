using SnakesAndLadders.Dice;
using SnakesAndLadders.GameSetup;
using SnakesAndLadders.Players;
using SnakesAndLadders.SeedData;
using SnakesAndLadders.Squares;
using Xunit;

namespace SnakesAndLaddersTest.GameSetup
{
    public class BoardTest
    {
        private readonly IBoard _board;
        public BoardTest()
        {
            _board = SeedBoard.CreateBoard(100);
        }

        [Fact]
        public void ChangePlayerPosition_WhenCalled_AssignPlayerToSquare()
        {
            //Arrange
            var player = new Player(new Die(), 100) {CurrentPosition = 11, Name = "Player1"};

            //Act
            _board.ChangePlayerPosition(new object(), new SquareEventArg{OldPosition = 8, Player = player});

            //Assert
            Assert.Single(_board.SquareList[10].Players);
        }

        [Fact]
        public void GetLastSquare_WhenCalled_ReturnsALastPositionObject()
        {
            //Act
            var lastSquare = _board.GetLastSquare();

            //Assert
            Assert.Equal(100, lastSquare.Position);
        }

        [Fact]
        public void GetSquareByIndex_WhenCalled_ReturnsASquareObject()
        {
            //Act
            var square = _board.GetSquareByIndex(2);

            //Assert
            Assert.Equal(2, square.Position);
        }
    }
}
