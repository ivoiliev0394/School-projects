using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivailo11A
{
    class Rectanglel
    {
        private double a;
        private double b;
        public Rectanglel()
        {
            this.a = 0;
            this.b = 0;

        }
        public Rectanglel(double a,double b)
        {
            this.a = a;
            this.b = b;
        }
        public Rectanglel(Rectanglel r)
        {
            this.a = r.a;
            this.b =r.b;
        }
        public double Lice()
        { return a * b; }
        public double Perim()
        { return 2*(a + b); }
        public void Information()
        {
            Console.WriteLine("Страните на правоъгълника са: a={0:F2}, b={1:F2}", a,b);
        }
        public bool Sravnenie()
        {
            //return (a == b);
            if (a == b) return true;
            else return false;
        }
    }
}
