using Moq;
using SnakesAndLadders.Dice;
using SnakesAndLadders.GameSetup;
using SnakesAndLadders.Players;
using Xunit;

namespace SnakesAndLaddersTest.GameSetup
{
    public class PlayTest
    {
        private readonly IPlay _play;
        private readonly Mock<IPlayer> _playerMock;
        public PlayTest()
        {
            var game = new Game();
            var playMessage = new PlayMessage();
            _play = new Play(game, playMessage);
            _playerMock = new Mock<IPlayer>();
            _playerMock.Setup(x => x.CurrentPosition).Returns(50);
            _playerMock.Setup(x => x.Move()).Callback(() => _playerMock.Setup(x => x.CurrentPosition).Returns(53));
        }

        [Fact]
        public void StartGame_WhenCalled_CreateTheGame()
        {
            //Act
            _play.StartGame();

            //Assert
            Assert.Equal(100, _play.Game.TopPosition);
            Assert.Equal(2, _play.Game.Players.Count);
            Assert.Equal(100, _play.Game.Board.SquareList.Count);
        }

        [Fact]
        public void RollDice_WhenCalledWithAWinner_StopTheIteration()
        {
            //Arrange
            _play.Game.CreateGame();
            var player1 = _play.Game.Players[0];
            player1.CurrentPosition = 100;

            var player2 = _play.Game.Players[1];
            player2.CurrentPosition = 50;

            _play.Game.Board.SquareList[99].Players.Add(player1);

            var lastSquare = _play.Game.Board.GetLastSquare();
            lastSquare.HasAWinner = true;

            //Act
            _play.RollDice();

            //Assert
            Assert.Equal(50, player2.CurrentPosition); //The player 2 should not change position when there is a winner
        }

        [Fact]
        public void MoveAllPlayers_WhenCalled_IncreaseThePositionOfAllPlayers()
        {
            //Arrange
            _play.Game.CreateGame();
            var player1 = _play.Game.Players[0];
            player1.CurrentPosition = 11;
            var player2 = _play.Game.Players[1];
            player2.CurrentPosition = 11;

            _play.Game.Board.SquareList[10].Players.Add(player1);
            _play.Game.Board.SquareList[10].Players.Add(player2);

            //Act
            _play.MoveAllPlayers();

            //Assert
            Assert.True(player1.CurrentPosition > 11);
            Assert.True(player2.CurrentPosition > 11);
        }

        [Fact]
        public void MovePlayer_WhenCalled_ChangeThePlayerPosition()
        {
            //Arrange
            _play.Game.CreateGame();

            //Act
            Assert.Empty(_play.Game.Board.SquareList[52].Players); //Check that the position does not have any player first
            _play.MovePlayer(_playerMock.Object);

            //Assert
            Assert.Single(_play.Game.Board.SquareList[52].Players); 
        }

        [Fact]
        public void MovePlayer_WhenCalled_RemoveThePlayerFromThePreviousPosition()
        {
            //Arrange
            _play.Game.CreateGame();
            _play.Game.Board.SquareList[49].Players.Add(_playerMock.Object);

            //Act
            _play.MovePlayer(_playerMock.Object);

            //Assert
            Assert.Empty(_play.Game.Board.SquareList[49].Players);
        }

        [Fact]
        public void RemovePlayer_WhenCalled_RemoveThePlayerFromThatSquare()
        {
            //Arrange
            var player = new Player(new Die(), 100){CurrentPosition = 50};
            _play.Game.CreateGame();
            _play.Game.Board.SquareList[49].Players.Add(player);

            //Act
            _play.RemovePlayer(player, 50);

            //Assert
            Assert.Empty(_play.Game.Board.SquareList[50].Players);
        }

        [Fact]
        public void ChangePlayerPosition_WhenCalled_AssignPlayerToSquare()
        {
            //Arrange
            var player = new Player(new Die(), 100) { CurrentPosition = 11 };
            _play.Game.CreateGame();
           
            //Act
            _play.ChangePlayerPosition(player);

            //Assert
            Assert.Single(_play.Game.Board.SquareList[10].Players);
        }

        [Fact]
        public void CheckForWinner_WhenCalled_AtTheBegginingOfTheGame_ReturnsFalse()
        {
            //Act
            _play.Game.CreateGame();
            var result = _play.CheckForWinner();

            //Assert
            Assert.False(result);
        }
    }
}
