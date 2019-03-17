using System;
using SnakesAndLadders.Dice;

namespace SnakesAndLadders.Players
{
    public class Player: IPlayer
    {
        public int CurrentPosition { get; set; }
        public string Name { get; set; }

        private readonly int _lastPosition;
        private readonly IDie _die;
        public Player(IDie die, int lastPosition)
        {
            _die = die;
            _lastPosition = lastPosition;
        }

        public void Move()
        {
            var newPosition = CurrentPosition + _die.Roll();

            if (newPosition <= _lastPosition)
            {
                CurrentPosition = newPosition;
            }
            else
            {
                Console.WriteLine($"--> {Name} tried to go outside of the board, so will stop at the current Position: {CurrentPosition}");
            }
        }
    }
}
