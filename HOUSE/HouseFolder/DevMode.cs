using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOUSE.House.Checks.cs;
using HOUSE.HouseFolder;
using static HOUSE.House.Utility;

namespace HOUSE.House.House
{
    internal class DevMode
    {
        public static void RunDevMode()
        {
            passwordChecker();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==DevMode==");
            Console.WriteLine("1. Back");
            Console.WriteLine("2. House");
            Console.WriteLine("3. Settings (Under Construction)");
            Console.WriteLine("4. Instructions");
            Console.WriteLine("5. HOUSE.Checks.cs");

            var key = Utility.ReadMenuKey(
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
                    House2.RunHouseMenu();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    House2.RunHouse();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Utility.UnderConstruction();
                    RunDevMode();
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    HouseInstructions.RunHouseInstructions();
                    break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Utility.UnderConstruction();
                    RunDevMode();
                    break;
            }
        }
        public static void RunDevModeHouseChecks()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==DevMode==");
            Console.WriteLine("1. Back");
            Console.WriteLine("2. HOUSE.Checks.cs.CantEscape.RunCantEscape");
            Console.WriteLine("3. HOUSE.Checks.cs.DoorClosed.RunDoorClosed");
            Console.WriteLine("4. HOUSE.Checks.cs.DoorLocked.RunDoorLocked");
            Console.WriteLine("5. HOUSE.Checks.cs.WindowClosed.RunWindowClosed");
            Console.WriteLine("6. HOUSE.Checks.cs.WindowLocked.RunWindowLocked");
            Console.WriteLine("7. HOUSE.Checks.cs.ArmAlarm.RunArmAlarm");
            Console.WriteLine("7. HOUSE.Checks.cs.HideKnives.RunHideknives");

            var key = Utility.ReadMenuKey(
            ConsoleKey.D1, ConsoleKey.NumPad1,
            ConsoleKey.D2, ConsoleKey.NumPad2,
            ConsoleKey.D3, ConsoleKey.NumPad3,
            ConsoleKey.D4, ConsoleKey.NumPad4,
            ConsoleKey.D4, ConsoleKey.NumPad5,
            ConsoleKey.D4, ConsoleKey.NumPad6,
            ConsoleKey.D4, ConsoleKey.NumPad7,
            ConsoleKey.D4, ConsoleKey.NumPad8
            );

            switch (key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    RunDevMode();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Checks.cs.CantEscape.RunCantEscape();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Checks.cs.DoorClosed.RunDoorClosed();
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Checks.cs.DoorLocked.RunDoorLocked();
                    break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Checks.cs.WindowClosed.RunWindowClosed();
                    break;

                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    Checks.cs.WindowLocked.RunWindowlocked();
                    break;

                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    ArmAlarm.RunArmAlarm();
                    break;

                case ConsoleKey.D8:
                case ConsoleKey.NumPad8:
                    Checks.cs.WillCreated.RunWillCreated();
                    break;
            }
        }
        public static void RunDevModeHouse()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==DevMode==");
            Console.WriteLine("1. Back");
            Console.WriteLine("2. House.Main");
            Console.WriteLine("3. House.RunHouseMenu");
            Console.WriteLine("4. House.RunHouse");
            Console.WriteLine("5. House.RunHouseSettings");
            Console.WriteLine("6. House.RunHouseInstructions");

            var key = Utility.ReadMenuKey(
            ConsoleKey.D1, ConsoleKey.NumPad1,
            ConsoleKey.D2, ConsoleKey.NumPad2,
            ConsoleKey.D3, ConsoleKey.NumPad3,
            ConsoleKey.D4, ConsoleKey.NumPad4,
            ConsoleKey.D4, ConsoleKey.NumPad5,
            ConsoleKey.D4, ConsoleKey.NumPad6
            );

            switch (key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    RunDevMode();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    House2.Main();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    House2.RunHouseMenu();
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    House2.RunHouse();
                    break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    House2.RunHouseSettings();
                    break;

                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    House2.RunHouseInstructions();
                    break;
            }
        }
    }
}
