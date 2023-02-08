using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_And_Line.BL;
using Point_And_Line.DL;

namespace Point_And_Line.UI
{
    class MyPointUI
    {
        public static MyPoint takingPoints()
        {
            int x, y;
            Console.Write("Enter X : ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter Y : ");
            y = int.Parse(Console.ReadLine());
            MyPoint points = new MyPoint(x, y);
            return points;
        }
    }
}
