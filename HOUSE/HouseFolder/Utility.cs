using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOUSE.House
{
    public class Utility
    {
        public static void Sleep(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }
        public static ConsoleKey ReadMenuKey(params ConsoleKey[] validKeys)
        {
            while (Console.KeyAvailable)
                Console.ReadKey(true);

            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
            }
            while (!validKeys.Contains(key));

            return key;
        }

        public static void UnderConstruction()
        {
            Clear();
            Console.WriteLine("under construction\nreturning");
            Sleep(1000);
        }

        public static void FlickerText(string text, int durationMs = 2000)
        {
            var rand = new Random();
            DateTime endTime = DateTime.Now.AddMilliseconds(durationMs);

            while (DateTime.Now < endTime)
            {
                int visibleLength = rand.Next(1, text.Length + 1);
                string flicker = text.Substring(0, visibleLength);

                Console.Clear();
                Console.WriteLine(flicker);

                Thread.Sleep(rand.Next(50, 120));
            }

            Console.Clear();
        }

        public static void passwordChecker()
        {
            string correctPassword = "letmein";
            string endLoop = "end";
            TypeTextColored("Enter Your Password:", 30, ConsoleColor.Green);
            string userInput = Console.ReadLine();
            if (userInput != correctPassword && userInput != endLoop)
            {
                TypeTextColored("Your Password Is Incorrect, Try Again.", 30, ConsoleColor.Red);
                passwordChecker();
            }else if ( userInput == endLoop)
            {
                House2.RunHouseMenu();
            }
        }

        public static void TypeText(string text, int delayMs)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
            Console.WriteLine();
        }
        public static void TypeTextColored(string text, int delayMs, ConsoleColor color)
        {

            foreach (char c in text)
            {
                Console.ForegroundColor = color;
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
        public static void Clear()
        {
            Console.Clear();
        }
        public static void TypeTextDiffCollored(string text, int delayPerChar, ConsoleColor[] colors)
        {
            if (colors == null || colors.Length == 0) colors = new[] { ConsoleColor.White };

            int ci = 0;

            foreach (char c in text)
            {
                Console.ForegroundColor = colors[ci];
                Console.Write(c);
                Thread.Sleep(delayPerChar);

                ci = (ci + 1) % colors.Length;
            }
            Console.WriteLine();
            Console.ResetColor();
        }
        public static void TypeTextFlashing2(string text, int flashes, int intervalMs, params ConsoleColor[] colors)
        {
            if (flashes < 1) flashes = 1;
            if (colors == null || colors.Length == 0) colors = new[] { ConsoleColor.White };

            var prev = Console.ForegroundColor;

            int left = Console.CursorLeft;
            int top = Console.CursorTop;

            Console.ForegroundColor = colors[0];
            Console.Write(text);

            for (int i = 0; i < flashes; i++)
            {
                foreach (var color in colors)
                {
                    Console.ForegroundColor = color;
                    Console.SetCursorPosition(left, top);
                    Console.Write(text);
                    Thread.Sleep(intervalMs);
                }
            }
            Console.WriteLine();
            Console.ResetColor();

            Console.SetCursorPosition(left + text.Length, top);
        }
        public static void TypeTextColoredFlashing(string text, int delayPerChar, ConsoleColor[] colors)
        {
            if (colors == null || colors.Length == 0) colors = new[] { ConsoleColor.White };

            foreach (char c in text)
            {
                foreach (var color in colors)
                {
                    Console.ForegroundColor = color;
                    Console.Write(c);
                    Thread.Sleep(delayPerChar / colors.Length);

                    if (Console.CursorLeft > 0)
                    {
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    }
                }

                Console.ForegroundColor = colors[colors.Length - 1];
                Console.Write(c);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
