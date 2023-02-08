using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_And_Line.BL
{
    class MyPoint
    {
        private int x;
        private int y;
        public MyPoint()
        {
            this.x = 0;
            this.y = 0;
        }

        public MyPoint(int x, int y)
        {
            this.setX(x);
            this.setY(y);
        }
        public int getX()
        {
            return this.x;
        }
        public int getY()
        {
            return this.y;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double distanceWithCords(int x, int y)
        {
            int d = (x - this.x) * (x - this.x) + (y - this.y) * (y - this.y);
            return Math.Sqrt(d);
        }
        public double distanceWithObject(MyPoint another)
        {
            int d = (another.x - this.x) * (another.x - this.x) + (another.y - this.y) * (another.y - this.y);
            return Math.Sqrt(d);
        }
        public double distanceFromZero()
        {
            int d = (this.x) * (this.x) + (this.y) * (this.y);
            return Math.Sqrt(d);
        }
    }
}
