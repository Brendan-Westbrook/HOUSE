using HOUSE.Screens;
using static HOUSE.Core.Utility;

namespace HOUSE.Endings
{
    internal class EndGame
    {
        public static void RunEndGame()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Thread.Sleep(1000);
            Console.WriteLine("'hello....'");

            Thread.Sleep(2800);
            Console.Clear();


            Momo.Showmomo();
            Momo.Showmomo();
            Momo.Showmomo();

            Console.ResetColor();

            Thread.Sleep(1000);
            TypeTextColored("=====THANKS FOR PLAYING=====" +
                "\nEnding 1 Complete!" +
                "\n\nThis game is a work in progress." +
                "\nOther endings are coming soon!", 30, ConsoleColor.Yellow);
            Thread.Sleep(1000);
            Console.ReadKey();
        }
    }
}
