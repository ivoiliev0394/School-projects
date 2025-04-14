using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class Point
    {
        private int x;
        private int y;
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Point)) return false;
            Point p = (Point)obj;
            return x==p.x & y==p.y;
        }
        public override string ToString()
        {
            return "("+x+","+y+")";
        }
    }
}
