using HOUSE.Core;
using HOUSE.Endings;
using static HOUSE.Core.Utility;

namespace HOUSE.Checks
{
    internal class WindowClosed
    {
        public static void RunWindowClosed()
        {
            TypeTextColored("Did You Close The Windows?\n", 30, ConsoleColor.Red);

            string answer3 = Console.ReadLine().Trim().ToLower();

            bool validInput3 = false;
            while (!validInput3)
            {
                switch (answer3)
                {
                    case "yes":
                        validInput3 = true;
                        if (GameState.WindowClosed)
                        {
                            Thread.Sleep(1000);
                            TypeTextColored("\n....", 30, ConsoleColor.Red);
                            Thread.Sleep(1500);
                            TypeTextColored("\nYou hear a knock on your window....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nIt knows your here....", 50, ConsoleColor.Red);
                        }
                        else
                        {
                            Console.Clear();
                            Thread.Sleep(1000);
                            TypeTextColored("\nDid You?", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hear it hit the ground....", 30, ConsoleColor.Red); ;
                            Thread.Sleep(1000);
                            TypeTextColored("\nSomeone is in your house....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nIt is in your room....", 70, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            EndGame.RunEndGame();
                        }
                        break;

                    case "no":
                        validInput3 = true;
                        if (GameState.WindowClosed)
                        {
                            TypeTextColored("\nYou check your pill box and remember you didn't take your memory pills....", 30, ConsoleColor.Red);
                            Thread.Sleep(1500);
                            TypeTextColored("\nYou hear a knock on your window....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nIt knows your here....", 50, ConsoleColor.Red);
                        }
                        else
                        {
                            Console.Clear();
                            Thread.Sleep(1000);
                            TypeTextColored("\nDid You?", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hear it hit the ground....", 30, ConsoleColor.Red); ;
                            Thread.Sleep(1000);
                            TypeTextColored("\nSomeone is in your house....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nIt is in your room....", 70, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            EndGame.RunEndGame();

                        }
                        break;

                    default:
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.Write(new string(' ', Console.WindowWidth));
                        Console.SetCursorPosition(0, Console.CursorTop - 1);

                        break;
                }

            }
        }
    }
}
