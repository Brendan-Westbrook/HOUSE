using System;
using static HOUSE.House.Utility;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using HOUSE.House.Checks.cs;

namespace HOUSE.House
{
    public class Questions1
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

            Checks.cs.DoorClosed.RunDoorClosed();

            Thread.Sleep(1000);
            Console.Clear();

            Checks.cs.DoorLocked.RunDoorLocked();

            Thread.Sleep(1000);
            Console.Clear();

            Checks.cs.WindowClosed.RunWindowClosed();

            Thread.Sleep(1000);
            Console.Clear();

            Checks.cs.WindowLocked.RunWindowlocked();

            Thread.Sleep(1000);
            Console.Clear();

            ArmAlarm.RunArmAlarm();

            Thread.Sleep(1000);
            Console.Clear();

            Checks.cs.WillCreated.RunWillCreated();

            Thread.Sleep(1000);
            Console.Clear();

            Checks.cs.CantEscape.RunCantEscape();
        }
    }
}
