using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HOUSE.House.Utility;
using HOUSE.House.House1;
using HOUSE.House.House;

namespace HOUSE.HouseFolder
{
    internal class HouseInstructions
    {
        public static void RunHouseInstructions()
        {
            Console.ResetColor();
            Console.Clear();

            Sleep(1000);
            TypeTextColored("=====WELCOME TO OUR HOUSE=====" +
                "\n\nIn this small Indie Game, you play as a man who needs to keep himself alive..." +
                "\n\nYou must do this through trial and error with a helpful ammount of memory...." +
                "\n\nIf you find yourself having to restart many times, and you dont want to listen to the opening dialouge, " +
                "\njust press any key, and it will skip." +
                "\n\nThere may be more to this game that you will have to discover..." +
                "\n\n=====HAVE FUN=====", 20, ConsoleColor.Green);
            Thread.Sleep(1000);
            TypeTextColored("*Press Any Key To Return*", 30, ConsoleColor.Green);
            Console.ReadKey(true);
            TypeTextColored("*returning*", 30, ConsoleColor.Green);
            Sleep(1000);
            House.House2.RunHouseMenu();
        }
    }
}
