using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_And_Line.BL;
using Point_And_Line.DL;

namespace Point_And_Line.UI
{
    class MyLineUI
    {
        public static MyLine makeLine()
        {
            Console.WriteLine("Begin Points");
            MyPoint begin = MyPointUI.takingPoints();
            Console.WriteLine("End Points");
            MyPoint end = MyPointUI.takingPoints();
            MyLine line = new MyLine(begin, end);
            return line;
        }
        public static void setBeginPoints()
        {
            Console.WriteLine("Update Begin Point");
        }
        public static void setEndPoints()
        {
            Console.WriteLine("Update End Point");
        }
        public static void viewBeginPoints()
        {
            Console.WriteLine("Line begin points is : " + "(" + MyLineCrud.line.getBegin().getX() + "," + MyLineCrud.line.getBegin().getY() + ")");
        }
        public static void viewEndPoints()
        {
            Console.WriteLine("Line begin points is : " + "(" + MyLineCrud.line.getEnd().getX() + "," + MyLineCrud.line.getEnd().getY() + ")");
        }
        public static void viewLengthOfTheLine()
        {
            Console.WriteLine("Length of the line is : " + MyLineCrud.line.getLength());
        }
        public static void viewGradientOfLine()
        {
            Console.WriteLine("Gradient of the Line is : " + MyLineCrud.line.getGradient());
        }
        public static void viewDistanceOfBeginPointFromZero()
        {
            Console.WriteLine("Distance of the Begin from Origin : " + MyLineCrud.line.getBegin().distanceFromZero());
        }
        public static void viewDistanceOfEndPointFromZero()
        {
            Console.WriteLine("Distance of the End from Origin : " + MyLineCrud.line.getEnd().distanceFromZero());
        }
    }
}
