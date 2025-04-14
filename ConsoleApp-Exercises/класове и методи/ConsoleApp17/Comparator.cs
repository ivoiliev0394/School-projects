using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Comparator : Figure
    {
        private double a, h;
        public Comparator(double a, double h)
        {
            this.a = a;
            this.h = h;
        }
        public override void INFO()
        {
            Console.WriteLine("Успоредник");
            Console.WriteLine("a=" + a + "       " + "h=" + h);
        }
        public override double Area()
        {
            return a * h ;
        }
    }
}
