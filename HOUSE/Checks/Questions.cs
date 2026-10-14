using HOUSE.Core;
using HOUSE.Endings;
using static HOUSE.Core.Utility;

namespace HOUSE.Checks
{
    public class Questions
    {
        public static void RunQuestions()
        {
            Thread.Sleep(500);
            Console.Clear();
            Thread.Sleep(1000);

            TypeTextColored("....", 30, ConsoleColor.Red);

            Thread.Sleep(1000);
            Console.Clear();
            Thread.Sleep(500);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            DoorClosed.RunDoorClosed();

            Thread.Sleep(1000);
            Console.Clear();

            DoorLocked.RunDoorLocked();

            Thread.Sleep(1000);
            Console.Clear();

            WindowClosed.RunWindowClosed();

            Thread.Sleep(1000);
            Console.Clear();

            WindowLocked.RunWindowlocked();

            Thread.Sleep(1000);
            Console.Clear();

            ArmAlarm.RunArmAlarm();

            Thread.Sleep(1000);
            Console.Clear();

            KnivesHidden.RunKnivesHidden();

            Thread.Sleep(1000);
            Console.Clear();

            if (GameState.GetGun == true)
            {
                GetGun.runGetGun();
                Program.RunHouseMenu();
            }
            else
            {
                CantEscape.RunCantEscape();
                Program.RunHouseMenu();
            }
        }
    }
}
