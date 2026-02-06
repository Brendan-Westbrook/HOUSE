using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HOUSE.House.Utility;

namespace HOUSE.House.House1
{
    internal class HouseChecks
    {
        public static void RunHouseChecks()
        {
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*WHAT WOULD YOU LIKE TO DO...*");
            bool isGoing = true;
            while (isGoing)
            {
                string input = Console.ReadLine().Trim().ToLower();

                switch (input)
                {
                    case var _ when input.Contains("bye") || input.Contains("end"):
                        House2.RunHouseMenu();
                        break;

                    case var _ when input.Contains("sleep"):
                        TypeTextColored("Your eyes close...", 40, ConsoleColor.Red);
                        Sleep(1000);
                        TypeTextColored("You drift into a deep sleep...", 20, ConsoleColor.Red);
                        Sleep(2000);
                        isGoing = false;
                        Questions1.RunQuestions();
                        break;

                    case var _ when input.Contains("light"):
                        GameState.LightsOff = true;
                        TypeTextColored("You remembered to turn off the lights....", 30, ConsoleColor.Red);
                        break;

                    case var _ when input.Contains("door") && input.Contains("close"):
                        GameState.DoorClosed = true;
                        TypeTextColored("You remembered to close the door....", 30, ConsoleColor.Red);
                        break;

                    case var _ when input.Contains("door") && input.Contains("lock"):
                        GameState.DoorLocked = true;
                        TypeTextColored("You remembered to lock the door....", 30, ConsoleColor.Red);
                        break;

                    case var _ when input.Contains("window") && input.Contains("close"):
                        GameState.WindowClosed = true;
                        TypeTextColored("You remembered to close the windows....", 30, ConsoleColor.Red);
                        break;

                    case var _ when input.Contains("window") && input.Contains("lock"):
                        GameState.WindowLocked = true;
                        TypeTextColored("You remembered to padlock the windows....", 30, ConsoleColor.Red);
                        break;

                    case var _ when input.Contains("garage") && input.Contains("close"):
                        GameState.GarageClosed = true;
                        TypeTextColored("You remembered to close the garage....", 30, ConsoleColor.Red);
                        break;

                    case var _ when input.Contains("alarm"):
                        GameState.AlarmRigged = true;
                        TypeTextColored("You remembered to arm the alarm....", 30, ConsoleColor.Red);
                        break;

                    case var _ when input.Contains("dog"):
                        GameState.DogFree = true;
                        TypeTextColored("You remembered to let the dog out of his cage....", 30, ConsoleColor.Red);
                        break;

                    case var _ when input.Contains("knife"):
                        GameState.KnifesHidden = true;
                        TypeTextColored("You remembered to hide the knives....", 30, ConsoleColor.Red);
                        break;

                    case var _ when input.Contains("bedroom"):
                        GameState.BedroomDoorLocked = true;
                        TypeTextColored("You remembered to lock the bedroom door....", 30, ConsoleColor.Red);
                        break;

                    case var _ when input.Contains("will"):
                        GameState.WillCreated = true;
                        TypeTextColored("You wrote your will....", 30, ConsoleColor.Red);
                        break;

                    case var _ when input.Contains("gun"):
                        GameState.GetGun = true;
                        TypeTextColored("You found the gun huh....", 40, ConsoleColor.Red);
                        break;
                }
            }
        }
    }
}
