using SnakesAndLadders.Squares;
using System.Collections.Generic;

namespace SnakesAndLadders.GameSetup
{
    public interface IBoard
    {
        List<ISquare> SquareList { get; set; }
        void ChangePlayerPosition(object source, SquareEventArg arg);
        LastPosition GetLastSquare();
        ISquare GetSquareByIndex(int position);
        void SubscribeToSquareEvents();
    }
}
