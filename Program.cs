using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_And_Line.BL;
using Point_And_Line.DL;
using Point_And_Line.UI;

namespace Point_And_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "lineInfo.txt";
            if (MyLineCrud.readFromFile(path))
            {
                Console.WriteLine("Data load Successfuly");
            }
            string option;
            while (true)
            {
                Console.Clear();
                option = " ";
                option = MenuUI.mainMenu();
                if (option == "1")
                {
                    MyLineCrud.line = MyLineUI.makeLine();
                    MyLineCrud.storeIntoFile(path);
                }
                else if (option == "2")
                {
                    MyLineUI.setBeginPoints();
                    MyPoint begin = MyPointUI.takingPoints();
                    MyLineCrud.setBeginPoints(begin);
                    MyLineCrud.storeIntoFile(path);
                }
                else if (option == "3")
                {
                    MyLineUI.setEndPoints();
                    MyPoint end = MyPointUI.takingPoints();
                    MyLineCrud.setEndPoints(end);
                    MyLineCrud.storeIntoFile(path);
                }
                else if (option == "4")
                {
                    MyLineUI.viewBeginPoints();
                    
                }
                else if (option == "5")
                {
                    MyLineUI.viewEndPoints();
                }
                else if (option == "6")
                {
                    MyLineUI.viewLengthOfTheLine();
                }
                else if (option == "7")
                {
                    MyLineUI.viewGradientOfLine();
                }
                else if (option == "8")
                {
                    MyLineUI.viewDistanceOfBeginPointFromZero();
                }
                else if (option == "9")
                {
                    MyLineUI.viewDistanceOfEndPointFromZero();
                }
                else if (option == "10")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    MenuUI.invalidInput();
                    continue;
                }
                MenuUI.clearScreen();
            }
        }
    }
}
