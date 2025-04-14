using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Rectangle : Figure
    {
        private double a, b;
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override void INFO()
        {
            Console.WriteLine("Правоъгълник");
            Console.WriteLine("a=" + a + "       " + "b=" + b);
        }
        public override double Area()
        {
            return a * b;
        }
    }
}
