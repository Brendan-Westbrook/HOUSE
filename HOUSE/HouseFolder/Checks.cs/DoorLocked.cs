using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HOUSE.House.Utility;

namespace HOUSE.House.Checks.cs
{
    internal class DoorLocked
    {
        public static void RunDoorLocked()
        {
            TypeTextColored("Did You Lock The Front Door?\n", 30, ConsoleColor.Red);

            string answer2 = Console.ReadLine().Trim().ToLower();

            bool validInput2 = false;
            while (!validInput2)
            {
                switch (answer2)
                {
                    case "yes":
                        validInput2 = true;
                        if (House1.GameState.DoorLocked)
                        {
                            Thread.Sleep(1000);
                            TypeTextColored("\nThe noise stops....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hear the shutters of your window rattle....", 30, ConsoleColor.Red);
                        }
                        else
                        {
                            Console.Clear();
                            Thread.Sleep(1000);
                            TypeTextColored("\nDid You?", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hear the rusty squeaking of your doorhinges....", 30, ConsoleColor.Red); ;
                            Thread.Sleep(1000);
                            TypeTextColored("\nSomeone is in your house....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYour dog starts to bark from inside the crate....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nIt is in your room....", 70, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            House.EndGame.RunEndGame();
                        }
                        break;

                    case "no":
                        validInput2 = true;
                        if (House1.GameState.DoorLocked)
                        {
                            TypeTextColored("\nYou check your pill box and remember you didn't take your memory pills....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nThe noise stops....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hear the shutters of your window rattle....", 30, ConsoleColor.Red);
                        }
                        else
                        {
                            Console.Clear();
                            TypeTextColored("\n....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hear the rusty squeaking of your doorhinges....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nSomeone is in your house....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYour dog starts to bark from inside the crate....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nIt is in your room....", 70, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            House.EndGame.RunEndGame();

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
