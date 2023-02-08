using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_And_Line.UI
{
    class MenuUI
    {
        public static string mainMenu()
        {
            Console.WriteLine("1 -> Make a Point");
            Console.WriteLine("2 -> Update the begin Point");
            Console.WriteLine("3 -> Update the end Point");
            Console.WriteLine("4 -> Show the begin Point");
            Console.WriteLine("5 -> Show the end point");
            Console.WriteLine("6 -> Get the Length of the Line");
            Console.WriteLine("7 -> Get the Gradient of the Line");
            Console.WriteLine("8 -> Find the distance of begin point from zero coordinates");
            Console.WriteLine("9 -> Find the distance of end point from zero coordinates");
            Console.WriteLine("10 -> Exit");
            string option;
            Console.Write("Your Option...");
            option = Console.ReadLine();
            return option;
        }
        public static void clearScreen()
        {
            Console.Write("Press any key to continue");
            Console.ReadKey();
        }
        public static void invalidInput()
        {
            Console.WriteLine("Invalid Input");
            Console.Write("Press any key to continue");
            Console.ReadKey();
        }
    }
}
