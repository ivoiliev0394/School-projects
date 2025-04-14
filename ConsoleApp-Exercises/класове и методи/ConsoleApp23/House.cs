using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class House : Home
    {
        private double areadvor;
        public House(double area, double areadvor):base(area)
        {
            this.areadvor = areadvor;
        }
        public override double Cena()
        {
            double s = base.Cena() + areadvor * cenadvor;
            return s;
        }
    }
}
