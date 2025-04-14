using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Paralelepiped : Rectangle
    {
        protected double c;
        public Paralelepiped(double a, double b, double c):base(a,b)
        {
            this.c = c;
        }
        public void Info1()
        {
            Console.WriteLine("a={0}      b={1}      c={2}", a, b, c);
        }
        public double Obem()
        {
            return a * b * c;
        }
        public double Povarhnina()
        {
            return 2*(a * b + a * c + b * c);
        }
    }
}
