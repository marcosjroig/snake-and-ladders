using SnakesAndLadders.Squares;
using System.Collections.Generic;

namespace SnakesAndLadders.GameSetup
{
    public class Board: IBoard
    {
        public List<ISquare> SquareList { get; set; }

        private readonly IPlayMessage _playMessage;
        public Board(IPlayMessage playMessage, List<ISquare> squareList)
        {
            _playMessage = playMessage;
            SquareList = squareList;
        }

        //This method get executed when a Snake or Ladder rise an event.
        public void ChangePlayerPosition(object source, SquareEventArg arg)
        {
            //Get the square where the player will me moved. The player could go Up or Down depending of getting a Snake or Ladder.
            var newSquare = SquareList[arg.Player.CurrentPosition - 1];

            _playMessage.PlayerMovedMessage(arg.Player, arg.OldPosition);
            newSquare.OnPlayerLanded(arg.Player);
        }

        public LastPosition GetLastSquare()
        {
            if (SquareList[SquareList.Count - 1].GetType() == typeof(LastPosition))
            {
                return SquareList[SquareList.Count - 1] as LastPosition;
            }

            return null;
        }

        public ISquare GetSquareByIndex(int position)
        {
            return SquareList[position - 1];
        }

        //The board subscribe to the events of their squares.
        public void SubscribeToSquareEvents()
        {
            foreach (var square in SquareList)
            {
                square.PositionChanged += ChangePlayerPosition;
            }
        }
    }
}
