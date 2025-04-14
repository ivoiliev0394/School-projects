using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Point
    {
        private double X;
        private double Y;
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public void Output()
        {
            Console.WriteLine("x={0}   y={1}", X, Y);
        }
        public void Output2()
        {
            Console.WriteLine("x={0:F2}   y={1:F2}", X, Y);
        }
        public void Output3()
        {
            Console.WriteLine("x={0:F0}   y={1:F0}", X, Y);
        }
    }
}
