using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HOUSE.House.Utility;

namespace HOUSE.House.Checks.cs
{
    internal class WillCreated
    {
        public static void RunWillCreated()
        {
            Thread.Sleep(1000);
            Console.Clear();

            TypeTextColored("Did You Write Your Will?\n", 30, ConsoleColor.Red);

            string answerWill = Console.ReadLine().Trim().ToLower();
            bool validInputWill = false;

            while (!validInputWill)
            {
                switch (answerWill)
                {
                    case "yes":
                        validInputWill = true;
                        if (House1.GameState.WillCreated)
                        {
                            Thread.Sleep(1000);
                            TypeTextColored("\nThe papers sit neatly on your desk....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nSigned. Dated. Final....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nEverything you have....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nLeft to your everything....", 30, ConsoleColor.Red);
                        }
                        else
                        {
                            Console.Clear();
                            Thread.Sleep(1000);
                            TypeTextColored("\nDid You?", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYour desk is empty....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nThe pen beside it is still uncapped....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou can't fix it....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nSomeone is in your room....", 70, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            House.EndGame.RunEndGame();
                        }
                        break;

                    case "no":
                        validInputWill = true;
                        if (House1.GameState.WillCreated)
                        {
                            TypeTextColored("\nYou already wrote it. Even if you try to deny it....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nThe ink is dry....", 30, ConsoleColor.Red);
                        }
                        else
                        {
                            Console.Clear();
                            TypeTextColored("\n....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nThe pen rolls off the desk....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou can't stop it....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nSomeone is in your room....", 70, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            House.EndGame.RunEndGame();
                        }
                        break;

                    default:
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.Write(new string(' ', Console.WindowWidth));
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        answerWill = Console.ReadLine().Trim().ToLower();
                        break;
                }
            }
        }
    }
}
