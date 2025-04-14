using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Repair();
            myCar.Drive();

            /* 
             Car myCar = new Car();
             ICar car = myCar;
             car.Drive();
             car.Repair();
            */

            Triangle k = new Triangle(15, 14, 13);
            Console.WriteLine("P={0}",k.Perimeter()); 
            Console.WriteLine("S={0}",k.Face());
            
        }
    }
}
