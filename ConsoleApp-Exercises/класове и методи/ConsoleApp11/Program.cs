using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
      
        static void Main(string[] args)
        {
            double r;
            do
            {
                Console.Write("R=");
                r = double.Parse(Console.ReadLine());
            } while (r <= 0);
            Console.WriteLine("s на кръг с R={0} e: {1}", r,Math.Round(Circle.Face(r),2));
            Console.WriteLine("p на кръг с R={0} e: {1}", r, Math.Round(Circle.Perimeter(r),2));
            Console.WriteLine("V на кълбо с R={0} e: {1}", r, Math.Round(Sphere.Surface(r),2));
            Console.WriteLine("S на кълбо с R={0} e: {1}", r,Math.Round(Sphere.Volume(r),2));
             
            
           /*
            Student u1 = new Student("Ani",4);
            Student u2 = new Student("Ivan",5);
            u1.INFO();
            u2.INFO(); 
            Console.Write("Броят на учениците е ");
            Student.PrintCount();
             */
              
        }
    }
}
