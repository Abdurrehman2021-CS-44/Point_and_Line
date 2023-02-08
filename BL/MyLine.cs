using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_And_Line.DL;
using System.IO;

namespace Point_And_Line.BL
{
    class MyLine
    {
        private MyPoint begin;
        private MyPoint end;
        public MyLine()
        {
            this.begin.setXY(0,0);
            this.end.setXY(0, 0);
        }
        public MyLine(MyPoint begin, MyPoint end)
        {
            this.begin = begin;
            this.end = end;
        }
        public MyPoint getBegin()
        {
            return this.begin;
        }
        public void setBegin(MyPoint begin)
        {
            this.begin = begin;
        }
        public MyPoint getEnd()
        {
            return this.end;
        }
        public void setEnd(MyPoint end)
        {
            this.end = end;
        }
        public double getLength()
        {
            return begin.distanceWithObject(end);
        }
        public double getGradient()
        {
            int m = (end.getY() - begin.getY()) / (end.getX() - begin.getX());
            return m;
        }
    }
}
