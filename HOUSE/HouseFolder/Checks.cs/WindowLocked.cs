using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HOUSE.House.Utility;

namespace HOUSE.House.Checks.cs
{
    internal class WindowLocked
    {
        public static void RunWindowlocked()
        {
            TypeTextColored("Did You Lock The Windows?\n", 30, ConsoleColor.Red);

            string answer4 = Console.ReadLine().Trim().ToLower();

            bool validInput4 = false;
            while (!validInput4)
            {
                switch (answer4)
                {
                    case "yes":
                        validInput4 = true;
                        if (House1.GameState.WindowLocked)
                        {
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hear the sound of the window latch catching, blocking its entrance...", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\n....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nWhere did it go....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            Console.Clear();
                            TypeTextColored("\n....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hear the sound of glass shattering....", 50, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Thread.Sleep(1000);
                            TypeTextColored("\nDid You?", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hear the window shatter as glass pieces hit the ground....", 30, ConsoleColor.Red); ;
                            Thread.Sleep(1000);
                            TypeTextColored("\nSomeone is in your house....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nSomone is walking on broken glass....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nIt is in your room....", 70, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            House.EndGame.RunEndGame();
                        }  
                        break;

                    case "no":
                        validInput4 = true;
                        if (House1.GameState.WindowLocked)
                        {
                            TypeTextColored("\nYou check your pill box and remember you didn't take your memory pills....", 30, ConsoleColor.Red);
                            Thread.Sleep(1500);
                            TypeTextColored("\nYou hear the sound of the window latch catching, blocking its entrance...", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\n....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nWhere did it go....", 30, ConsoleColor.Red);
                        }
                        else
                        {
                            Console.Clear();
                            TypeTextColored("\n....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nDid You?", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nYou hear the window shatter as glass pieces hit the ground....", 30, ConsoleColor.Red); ;
                            Thread.Sleep(1000);
                            TypeTextColored("\nSomeone is in your house....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nSomone is walking on broken glass....", 30, ConsoleColor.Red);
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
