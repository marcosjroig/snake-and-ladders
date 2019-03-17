using SnakesAndLadders.Dice;
using SnakesAndLadders.GameSetup;
using SnakesAndLadders.Players;
using Xunit;

namespace SnakesAndLaddersTest.GameSetup
{
    public class PlayMessageTest
    {
        private readonly IPlayer _player;
        private readonly PlayMessage _playMessage;
        public PlayMessageTest()
        {
            _player = new Player(new Die(), 100) { CurrentPosition = 50, Name = "Player1" };
            _playMessage = new PlayMessage();
        }

        [Fact]
        public void PlayerLandedMessage_WhenCalled_ShowALandedMessage()
        {
            //Arrange
            var message = "--> Player1 landed at position: 50";

            //Act
            _playMessage.PlayerLandedMessage(_player);

            //Assert
            Assert.Equal(message, _playMessage.Message);

        }

        [Fact]
        public void PlayerMovedMessage_WhenCalled_ShowLadderMessage()
        {
            //Arrange
            var oldPosition = 30;
            var message = $"--> {_player.Name} has found a Ladder :-) and will be moved to position: {_player.CurrentPosition}";

            //Act
            _playMessage.PlayerMovedMessage(_player, oldPosition);

            //Assert
            Assert.Equal(message, _playMessage.Message);
        }

        [Fact]
        public void PlayerMovedMessage_WhenCalled_ShowSnakeMessage()
        {
            //Arrange
            var oldPosition = 70;
            var message = $"--> {_player.Name} has found a Snake :-( and will be moved to position: {_player.CurrentPosition}";

            //Act
            _playMessage.PlayerMovedMessage(_player, oldPosition);

            //Assert
            Assert.Equal(message, _playMessage.Message);
        }
    }
}
