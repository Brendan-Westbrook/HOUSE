using HOUSE.Checks;
using HOUSE.Core;
using HOUSE.Endings;
using static HOUSE.Core.Utility;

namespace HOUSE.Screens
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
            Console.WriteLine("5. HOUSE.Checks");

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
                    Program.RunHouseMenu();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Program.RunHouse();
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
            Console.WriteLine("2. HOUSE.Endings.CantEscape.RunCantEscape");
            Console.WriteLine("3. HOUSE.Checks.DoorClosed.RunDoorClosed");
            Console.WriteLine("4. HOUSE.Checks.DoorLocked.RunDoorLocked");
            Console.WriteLine("5. HOUSE.Checks.WindowClosed.RunWindowClosed");
            Console.WriteLine("6. HOUSE.Checks.WindowLocked.RunWindowLocked");
            Console.WriteLine("7. HOUSE.Checks.ArmAlarm.RunArmAlarm");
            Console.WriteLine("7. HOUSE.Checks.HideKnives.RunHideknives");

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
                    CantEscape.RunCantEscape();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    DoorClosed.RunDoorClosed();
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    DoorLocked.RunDoorLocked();
                    break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    WindowClosed.RunWindowClosed();
                    break;

                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    WindowLocked.RunWindowlocked();
                    break;

                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    ArmAlarm.RunArmAlarm();
                    break;

                case ConsoleKey.D8:
                case ConsoleKey.NumPad8:
                    WillCreated.RunWillCreated();
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
            Console.WriteLine("2. Program.Main");
            Console.WriteLine("3. Program.RunHouseMenu");
            Console.WriteLine("4. Program.RunHouse");
            Console.WriteLine("5. Program.RunHouseSettings");
            Console.WriteLine("6. Program.RunHouseInstructions");

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
                    Program.Main();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Program.RunHouseMenu();
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Program.RunHouse();
                    break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Program.RunHouseSettings();
                    break;

                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    Program.RunHouseInstructions();
                    break;
            }
        }
    }
}
