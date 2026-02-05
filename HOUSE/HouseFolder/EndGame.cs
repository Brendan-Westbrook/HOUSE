using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOUSE.House.House
{
    internal class EndGame
    {
        public static void RunEndGame()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Thread.Sleep(1000);
            Console.WriteLine("'hello....'");

            Thread.Sleep(2800);
            Console.Clear();


            Momo.Showmomo();
            Momo.Showmomo();
            Momo.Showmomo();

            Console.ResetColor();

            House2.RunHouseMenu();
        }
    }
}
