using System;

namespace SnakesAndLadders.Dice
{
    public class Die: IDie
    {
        public int Roll()
        {
            var random = new Random();

            //Random between 1 and 6
            return random.Next(1, 7);
        }
    }
}
