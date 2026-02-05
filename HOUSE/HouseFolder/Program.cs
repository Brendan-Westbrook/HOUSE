using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HOUSE.House.Utility;
using HOUSE.House.House1;
using HOUSE.House.House;

namespace HOUSE.House
{
    public class House2
    {
        public static void Main()
        {
            Console.ResetColor();
            Console.Clear();
            Sleep(1000);
            TypeText(".....", 20);
            Sleep(750);
            Clear();
            FlickerText("Welcome to house...", 500);
            Momo.Showmomo();
            FlickerText("Welcome to house...", 500);
            RunHouseMenu();
        }
        public static void RunHouseMenu()
        {
            Clear();
            Console.ResetColor();
            TypeText("Choose Your Option: ", 10);
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Instructions");
            Console.WriteLine("3. Settings");
            Console.WriteLine("4. Quit");
            Console.WriteLine("5. Dev");

            var key = ReadMenuKey(
            ConsoleKey.D1, ConsoleKey.NumPad1,
            ConsoleKey.D2, ConsoleKey.NumPad2,
            ConsoleKey.D3, ConsoleKey.NumPad3,
            ConsoleKey.D4, ConsoleKey.NumPad4,
            ConsoleKey.D5, ConsoleKey.NumPad5
            );

            switch (key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    RunHouse();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    RunHouseSettings();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    RunHouseInstructions();
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Environment.Exit(0);
                    break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    DevMode.RunDevMode();
                    break;
            }
        }

        public static void RunHouse()
        {
            bool skip = false;

            void CheckSkip()
            {
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    skip = true;
                }
            }

            Console.Clear();
            Console.ResetColor();

            CheckSkip(); if (skip) goto End;
            TypeText("'Dear!'\n", 20);

            CheckSkip(); if (skip) goto End;
            Sleep(1000);
            TypeTextColored("Its your wife....\n", 30, ConsoleColor.Red);

            CheckSkip(); if (skip) goto End;
            Sleep(1000);
            TypeText("'Go to bed! You've been playing that stupid horror game for three hours!'\n", 20);

            CheckSkip(); if (skip) goto End;
            Sleep(1000);
            TypeTextColored("She's angry....", 30, ConsoleColor.Red);

            CheckSkip(); if (skip) goto End;
            Sleep(250);
            TypeTextColored("You better go to bed....\n", 30, ConsoleColor.Red);

            CheckSkip(); if (skip) goto End;
            Sleep(1000);
            TypeTextColored("'Okay, Goodnight.'\n", 20, ConsoleColor.Yellow);

            CheckSkip(); if (skip) goto End;
            Sleep(1000);
            TypeTextColored("You put down the controller and turn off the Xbox....", 30, ConsoleColor.Red);

            CheckSkip(); if (skip) goto End;
            Sleep(250);
            TypeTextColored("The Xbox logo flickers off....\n", 30, ConsoleColor.Red);

            CheckSkip(); if (skip) goto End;
            Sleep(1000);
            TypeTextColored("But....\n", 30, ConsoleColor.Red);

            CheckSkip(); if (skip) goto End;
            Sleep(1000);
            TypeTextColored("*TV SCREEN*: 'HOUSE'\n", 50, ConsoleColor.Green);

            CheckSkip(); if (skip) goto End;
            Sleep(1000);
            TypeTextColored("The TV is still showing the frozen screen of the game....\n", 30, ConsoleColor.Red);

            CheckSkip(); if (skip) goto End;
            Sleep(1000);
            TypeTextColored("You stare at the screen, unsure if it's going to turn off....\n", 30, ConsoleColor.Red);

            CheckSkip(); if (skip) goto End;
            Sleep(1000);
            TypeTextColored("....\n", 30, ConsoleColor.Red);

            CheckSkip(); if (skip) goto End;
            Sleep(1000);
            TypeTextColored("The screen isn't that bright, you can stand the light for tonight....\n", 30, ConsoleColor.Red);

            CheckSkip(); if (skip) goto End;
            Sleep(1000);
            TypeTextColored("Time To Sleep....\n", 30, ConsoleColor.Red);

        End:
            Sleep(1000);
            House1.HouseChecks.RunHouseChecks();
        }
        public static void RunHouseSettings()
        {
            UnderConstruction();
            RunHouseMenu();
        }
        public static void RunHouseInstructions()
        {
            UnderConstruction();
            RunHouseMenu();
        }
    }
}