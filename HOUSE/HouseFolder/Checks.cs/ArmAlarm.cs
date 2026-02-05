using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HOUSE.House.Utility;

namespace HOUSE.House.Checks.cs
{
    internal class ArmAlarm
    {
        public static void RunArmAlarm()
        {
            Thread.Sleep(1000);
            Console.Clear();

            TypeTextColored("Did You Arm the Alarm?\n", 30, ConsoleColor.Red);

            string answerAlarm = Console.ReadLine().Trim().ToLower();
            bool validInputAlarm = false;

            while (!validInputAlarm)
            {
                switch (answerAlarm)
                {
                    case "yes":
                        validInputAlarm = true;
                        if (House1.GameState.AlarmRigged)
                        {
                            Thread.Sleep(1000);
                            TypeTextColored("\nA soft beep echoes from the control panel....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nA faint red glow pulses in the dark....", 30, ConsoleColor.Red);
                        }
                        else
                        {
                            Console.Clear();
                            Thread.Sleep(1000);
                            TypeTextColored("\nDid You?", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nThe alarm panel is dark.... silent.... useless....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nA door creaks open in the distance....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nSomeone is in your house....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nIt is in your room....", 70, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            House.EndGame.RunEndGame();
                        }
                        break;

                    case "no":
                        validInputAlarm = true;
                        if (House1.GameState.AlarmRigged)
                        {
                            TypeTextColored("\nYou check the panel — the red light blinks reassuringly....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nBut you still hear something outside....", 30, ConsoleColor.Red);
                        }
                        else
                        {
                            Console.Clear();
                            TypeTextColored("\n....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nThe silence in the hall feels wrong....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nA door creaks open in the distance....", 30, ConsoleColor.Red);
                            Thread.Sleep(1000);
                            TypeTextColored("\nSomeone is in your house....", 30, ConsoleColor.Red);
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
                        answerAlarm = Console.ReadLine().Trim().ToLower();
                        break;
                }
            }
        }
    }
}
