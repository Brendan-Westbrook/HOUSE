using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HOUSE.House.Utility;
using HOUSE.House.House1;
using HOUSE.House.House;

namespace HOUSE.HouseFolder.Checks.cs
{
    internal class GetGun
    {
        public static void runGetGun()
        {
            Console.Clear();
            Console.ResetColor();
            Thread.Sleep(1000);
            TypeTextColored("You take the shotgun, slowly and silently loading it....\n", 30, ConsoleColor.Red);
            Thread.Sleep(1000);
            TypeTextColored("You cock the shotgun loud....\n", 30, ConsoleColor.Red);
            Thread.Sleep(1000);
            TypeTextColored("It stops turning the handle....\n", 30, ConsoleColor.Red);
            Thread.Sleep(1000);
            TypeTextColored("You raise the shotgun, pointing it at the door, waiting....\n", 30, ConsoleColor.Red);
            Thread.Sleep(1000);
            Console.Clear();
            Thread.Sleep(1000);
            TypeTextColored("....", 30, ConsoleColor.Red);
            Thread.Sleep(1000);
            Console.Clear();
            Thread.Sleep(500);
            TypeTextColored("The door swings wide," +
                "\n\nYou pull the trigger and with a bang that shakes your bones," +
                "\n\nthe door splinters into thousands of tiny fragments that shoot in every direction", 30, ConsoleColor.Red);
            Thread.Sleep(1500);
            Console.Clear();
            Thread.Sleep(1000);
            TypeTextColored("But....", 30, ConsoleColor.Red);
            Thread.Sleep(1000);
            Console.Clear();
            Thread.Sleep(1000);
            TypeTextColored("No one is there...", 30, ConsoleColor.Red);
            Thread.Sleep(1000);
            Console.Clear();
            TypeTextColored("Your Wife...", 70, ConsoleColor.Red);
            Thread.Sleep(1000);
            TypeTextColored("What have you done...", 70, ConsoleColor.Red);
            Thread.Sleep(1000);
            Console.Clear();

            Momo.Showmomo();
            Momo.Showmomo();
            Momo.Showmomo();

            Thread.Sleep(1000);
            TypeTextColored("=====THANKS FOR PLAYING=====" +
                "\nEnding 2 Complete!" +
                "\n\nThis game is a work in progress." +
                "\nOther endings are coming soon!", 30, ConsoleColor.Yellow);
            Thread.Sleep(1000);
            Console.ReadKey();
        }
    }
}
