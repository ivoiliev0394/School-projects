using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class Building
    {
        protected double area;
        protected int etaji;
        public Building()
        {
            this.area = 0;
            this.etaji = 0;
        }
        public Building(double area, int etaji)
        {
            this.area = area;
            this.etaji = etaji;
        }
        public virtual void INFO()
        {
            Console.WriteLine("Сградата е на площ {0} кв.м. и бр. етажи {1}",area,etaji);
        }
        public static bool operator > (Building a, Building b)
        {
            if (a > b) return true;
            else return false;
        }
        public static bool operator <(Building a, Building b)
        {
            if (a < b) return true;
            else return false;
        }
    }
}
