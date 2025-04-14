using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class Home
    {
        protected double area;
        private double cenahome = 500;
        protected double cenadvor = 30;
        public Home(double area)
        {
            this.area = area;
        }
        public virtual double Cena()
        {
            return area * cenahome;
        }
    }
}
