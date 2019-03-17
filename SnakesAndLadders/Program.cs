using SnakesAndLadders.GameSetup;
using System;

namespace SnakesAndLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            HeaderMessage();

            IPlay play = new Play(new Game(), new PlayMessage());
            play.StartGame();

            FooterMessage();

            Console.ReadKey();
        }

        private static void HeaderMessage()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Snakes & Ladders");
            Console.WriteLine("-----------------");
            Console.WriteLine(string.Empty);
        }

        private static void FooterMessage()
        {
            Console.WriteLine(string.Empty);
            Console.WriteLine("-----------------");
            Console.WriteLine("--- Game Over ---");
            Console.WriteLine("-----------------");
        }
    }
}
