using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_And_Line.BL;
using Point_And_Line.UI;
using System.IO;

namespace Point_And_Line.DL
{
    class MyLineCrud
    {
        public static MyLine line = new MyLine();
        public static void setBeginPoints(MyPoint begin)
        {
            line.setBegin(begin);
        }
        public static void setEndPoints(MyPoint end)
        {
            line.setEnd(end);
        }
        public static bool readFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    int x1 = int.Parse(splittedRecord[0]);
                    int y1 = int.Parse(splittedRecord[1]);
                    int x2 = int.Parse(splittedRecord[2]);
                    int y2 = int.Parse(splittedRecord[3]);
                    MyPoint begin = new MyPoint(x1, y1);
                    MyPoint end = new MyPoint(x2, y2);
                    MyLineCrud.line = new MyLine(begin, end);
                }
                f.Close();
                return true;
            }
            return false;
        }
        public static void storeIntoFile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            f.WriteLine(line.getBegin().getX() + "," + line.getBegin().getY() + "," + line.getEnd().getX() + "," + line.getEnd().getY());
            f.Flush();
            f.Close();
        }
    }
}
