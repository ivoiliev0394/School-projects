using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Circle : Point
    {
        private double R;
        static private double pi = 3.14;
       
        public Circle(double X, double Y, double R) : base(X, Y)
        {
            this.R = R;
        }
        public Circle():base()
        {
            R = 0;
        }
        public void ShowCircle()
        {
            base.Output();
            Console.WriteLine("R={0}", R);
        }
        public void ShowCircle2()
        {
            base.Output2();
            Console.WriteLine("R={0:F2}", R);
        }
        public void ShowCircle3()
        {
            base.Output3();
            Console.WriteLine("R={0:F0}", R);
        } 
        static public double Face(double R)
        { return pi * R * R; }
    }
}
