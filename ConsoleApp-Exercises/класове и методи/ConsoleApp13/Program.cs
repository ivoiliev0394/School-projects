using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Окръжност 1");
            Circle O1=new Circle();
            O1.ShowCircle();   //O1.ShowCircle2(); // O1.ShowCircle3();
            Console.WriteLine();
            Console.WriteLine("Окръжност 2");
            double r;
            do
            {
                Console.Write("R=");
                r = double.Parse(Console.ReadLine());
            } while (r <= 0);

            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Circle O2 = new Circle(x,y,r);
            O2.ShowCircle();  // O2.ShowCircle2();  // O2.ShowCircle3();
            Console.WriteLine();
            Console.WriteLine("S на окръжност 2 е: {0}", Math.Round(Circle.Face(r), 2));
            //Console.WriteLine("S на окръжност 2 е: {0}", Math.Round(Circle.Face(r), 0));
            Console.WriteLine();


        }
    }
}
