using HOUSE.Core;
using HOUSE.Endings;
using static HOUSE.Core.Utility;

namespace HOUSE.Checks
{
    internal class DoorClosed
    {
        // Returns false if the player died.
        public static bool RunDoorClosed()
        {
            TypeTextColored("Did You Close The Front Door?\n", 30, ConsoleColor.Red);

            string answer1 = Console.ReadLine().Trim().ToLower();

            bool validInput1 = false;

            while (!validInput1)
            {
                switch (answer1)
                {
                    case "yes":
                        validInput1 = true;
                        if (GameState.DoorClosed)
                        {
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hear your door camera make a noise....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nSomebody's at the door....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.Clear();
                            Thread.Sleep(1000);
                            TypeTextColored("\nDid You?", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nSomebody opens the front door....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nSomeone is in your house....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nIt is in your room....", 70, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            EndGame.RunEndGame();
                            return false;
                        }
                        break;

                    case "no":
                        validInput1 = true;
                        if (GameState.DoorClosed)
                        {
                            TypeTextColored("\nYou check your pill box and remember you didn't take your memory pills....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hear your door camera make a noise, somebody's at the door....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hear your doorknob rattle....", 30, ConsoleColor.Red);
                        }
                        else
                        {
                            Console.Clear();
                            TypeTextColored("\n....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nSomebody opens the front door....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nSomeone is in your house....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nIt is in your room....", 70, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            EndGame.RunEndGame();
                            return false;
                        }
                        break;

                    default:
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.Write(new string(' ', Console.WindowWidth));
                        Console.SetCursorPosition(0, Console.CursorTop - 1);

                        answer1 = Console.ReadLine()?.Trim().ToLower();
                        break;
                }
            }
            return true;
        }
    }
}
