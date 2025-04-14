using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Rectangle
    {
        protected double a;
        protected double b;
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public void Info()
        {
            Console.WriteLine("a={0}      b={1}", a, b);
        }
        public double Lice()
        {
            return a * b;
        }

    }
}
