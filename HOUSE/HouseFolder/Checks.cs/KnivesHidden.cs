using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HOUSE.House.Utility;

namespace HOUSE.House.Checks.cs
{
    internal class KnivesHidden
    {
        public static void RunKnivesHidden()
        {
            Thread.Sleep(1000);
            Console.Clear();

            TypeTextColored("Did You Hide The Knives?\n", 30, ConsoleColor.Red);

            string answerWill = Console.ReadLine().Trim().ToLower();
            bool validInputWill = false;

            while (!validInputWill)
            {
                switch (answerWill)
                {
                    case "yes":
                        validInputWill = true;
                        if (House1.GameState.KnifesHidden)
                        {
                            Thread.Sleep(1000);
                            TypeTextColored("\nIt's heavy footsteps echoe through the silent house....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hear it outside your bedroom door....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nThe doorknob turns....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.Clear();
                            Thread.Sleep(1000);
                            TypeTextColored("\nDid You?", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hear the unsheathing of the knife....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hear it's foot steps....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hold your breath....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nSomeone is in your room....", 70, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            House.EndGame.RunEndGame();
                        }
                        break;

                    case "no":
                        validInputWill = true;
                        if (House1.GameState.KnifesHidden)
                        {
                            TypeTextColored("\nYou can't check your pills, any noise will give you away....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nIt's heavy footsteps echo through the silent house....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hear it outside your bedroom door....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nThe doorknob turns....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.Clear();
                            TypeTextColored("\nYou hear the unsheathing of the knife....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hear it's foot steps....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hold your breath....", 30, ConsoleColor.Red);
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
