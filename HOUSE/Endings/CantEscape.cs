using static HOUSE.Core.Utility;

namespace HOUSE.Endings
{
    internal class CantEscape
    {
        public static void RunCantEscape()
        {
            Thread.Sleep(1000);
            Console.Clear();
            Console.ResetColor();

            TypeTextColored("'....'\n", 70, ConsoleColor.Red);
            Thread.Sleep(1000);
            Console.Clear();

            TypeTextColored("'Hi honey....'\n", 70, ConsoleColor.Red);
            Thread.Sleep(1000);
            Console.Clear();

            TypeTextColored("'I missed you....'\n", 70, ConsoleColor.Yellow);
            Thread.Sleep(1000);
            Console.Clear();

            TypeTextColoredFlashing("WELCOME TO OUR HOUSE...\n", 100, new[] { ConsoleColor.Red, ConsoleColor.DarkRed, ConsoleColor.Yellow });
            Console.Clear();
        }
    }
}