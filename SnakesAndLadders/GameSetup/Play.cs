using SnakesAndLadders.Players;

namespace SnakesAndLadders.GameSetup
{
    public class Play: IPlay
    {
        public IGame Game { get; set; }

        private readonly IPlayMessage _playMessage;
        public Play(IGame game, IPlayMessage playMessage)
        {
            Game = game;
            _playMessage = playMessage;
        }

        public void StartGame()
        {
            Game.CreateGame();
            RollDice();
        }

        public void RollDice()
        {
            while (CheckForWinner() == false)
            {
                MoveAllPlayers();
            }
        }

        public void MoveAllPlayers()
        {
            foreach (var player in Game.Players)
            {
                if (CheckForWinner())
                {
                    break;
                }

                MovePlayer(player);
            }
        }

        public void MovePlayer(IPlayer player)
        {
            var initialPosition = player.CurrentPosition;
            player.Move();

            if (player.CurrentPosition != initialPosition)
            {
                RemovePlayer(player, initialPosition);

                ChangePlayerPosition(player);
            }
        }

        public void RemovePlayer(IPlayer player, int initialPosition)
        {
            //Remove the player from the previous position
            var previousSquare = Game.Board.GetSquareByIndex(initialPosition);
            previousSquare.RemovePlayer(player);
        }

        public void ChangePlayerPosition(IPlayer player)
        {
            //Assign the player a new square
            var newSquare = Game.Board.GetSquareByIndex(player.CurrentPosition);
            _playMessage.PlayerLandedMessage(player);
            newSquare.OnPlayerLanded(player);
        }

        public bool CheckForWinner()
        {
            var lastPosition = Game.Board.GetLastSquare();
            return lastPosition.HasAWinner;
        }
    }
}
