using System.Linq;
using SnakesAndLadders.GameSetup;
using SnakesAndLadders.Squares;
using Xunit;

namespace SnakesAndLaddersTest.GameSetup
{
    public class GameTest
    {
        private readonly Game _game;
        public GameTest()
        {
            _game = new Game{TopPosition = 100};
        }

        [Fact]
        public void CreateGame_WhenCalled_ConfigureTheVariablesToStartTheGame()
        {
            //Act
            _game.CreateGame();

            //Assert
            Assert.Equal(100, _game.TopPosition);
            Assert.Equal(2, _game.Players.Count);
            Assert.Equal(100, _game.Board.SquareList.Count);
        }

        [Fact]
        public void CreatePlayers_WhenCalled_CreateThePlayersOfTheGame()
        {
            //Act
            _game.CreatePlayers();

            //Assert
            Assert.Equal(2, _game.Players.Count);
        }

        [Fact]
        public void CreateBoard_WhenCalled_CreateTheGameBoard()
        {
            //Act
            _game.CreateBoard();

            //Assert
            Assert.Equal(100, _game.Board.SquareList.Count);
        }

        [Fact]
        public void CreateSnakes_WhenCalled_CreateTheGameSnakes()
        {
            //Act
            _game.CreateBoard();
            _game.CreateSnakes();

            var snakesCounter = _game.Board.SquareList.Count(x => x.GetType() == typeof(Snake));

            //Assert
            Assert.Equal(12, snakesCounter);
        }

        [Fact]
        public void CreateLadders_WhenCalled_CreateTheGameLadders()
        {
            //Act
            _game.CreateBoard();
            _game.CreateLadders();

            var laddersCounter = _game.Board.SquareList.Count(x => x.GetType() == typeof(Ladder));

            //Assert
            Assert.Equal(13, laddersCounter);
        }
    }
}
