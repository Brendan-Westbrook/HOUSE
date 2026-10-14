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
            if (!passwordChecker()) return;
            RunDevModeMenu();
        }
        public static void RunDevModeMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("==DevMode==");
                Console.WriteLine("1. Back");
                Console.WriteLine("2. House");
                Console.WriteLine("3. Settings (Under Construction)");
                Console.WriteLine("4. Instructions");
                Console.WriteLine("5. HOUSE.Checks");
                Console.WriteLine("6. HOUSE.Program");

                var key = Utility.ReadMenuKey(
                ConsoleKey.D1, ConsoleKey.NumPad1,
                ConsoleKey.D2, ConsoleKey.NumPad2,
                ConsoleKey.D3, ConsoleKey.NumPad3,
                ConsoleKey.D4, ConsoleKey.NumPad4,
                ConsoleKey.D5, ConsoleKey.NumPad5,
                ConsoleKey.D6, ConsoleKey.NumPad6
                );

                switch (key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        return;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Program.RunHouse();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Utility.UnderConstruction();
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        HouseInstructions.RunHouseInstructions();
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        RunDevModeHouseChecks();
                        break;

                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        RunDevModeHouse();
                        break;
                }
            }
        }
        public static void RunDevModeHouseChecks()
        {
            while (true)
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
                Console.WriteLine("6. HOUSE.Checks.WindowLocked.RunWindowlocked");
                Console.WriteLine("7. HOUSE.Checks.ArmAlarm.RunArmAlarm");
                Console.WriteLine("8. HOUSE.Checks.KnivesHidden.RunKnivesHidden");
                Console.WriteLine("9. HOUSE.Checks.WillCreated.RunWillCreated");

                var key = Utility.ReadMenuKey(
                ConsoleKey.D1, ConsoleKey.NumPad1,
                ConsoleKey.D2, ConsoleKey.NumPad2,
                ConsoleKey.D3, ConsoleKey.NumPad3,
                ConsoleKey.D4, ConsoleKey.NumPad4,
                ConsoleKey.D5, ConsoleKey.NumPad5,
                ConsoleKey.D6, ConsoleKey.NumPad6,
                ConsoleKey.D7, ConsoleKey.NumPad7,
                ConsoleKey.D8, ConsoleKey.NumPad8,
                ConsoleKey.D9, ConsoleKey.NumPad9
                );

                switch (key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        return;

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
                        KnivesHidden.RunKnivesHidden();
                        break;

                    case ConsoleKey.D9:
                    case ConsoleKey.NumPad9:
                        WillCreated.RunWillCreated();
                        break;
                }
            }
        }
        public static void RunDevModeHouse()
        {
            while (true)
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
                ConsoleKey.D5, ConsoleKey.NumPad5,
                ConsoleKey.D6, ConsoleKey.NumPad6
                );

                switch (key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        return;

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
}
