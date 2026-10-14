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

            if (!DoorClosed.RunDoorClosed()) return;

            Thread.Sleep(1000);
            Console.Clear();

            if (!DoorLocked.RunDoorLocked()) return;

            Thread.Sleep(1000);
            Console.Clear();

            if (!WindowClosed.RunWindowClosed()) return;

            Thread.Sleep(1000);
            Console.Clear();

            if (!WindowLocked.RunWindowlocked()) return;

            Thread.Sleep(1000);
            Console.Clear();

            if (!ArmAlarm.RunArmAlarm()) return;

            Thread.Sleep(1000);
            Console.Clear();

            if (!KnivesHidden.RunKnivesHidden()) return;

            Thread.Sleep(1000);
            Console.Clear();

            if (GameState.GetGun == true)
            {
                GetGun.runGetGun();
            }
            else
            {
                CantEscape.RunCantEscape();
            }
        }
    }
}
