using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Car : ICAR
    {
        public void Repair() 
        {
            Console.WriteLine("Колата е на ремонт.");
        }
        public void Drive() 
        {
            Console.WriteLine("Колата е в движение.");
        }

        /*
        void ICar.Repair() 
        {
            Console.WriteLine("Колата е на ремонт.");
        }
        void ICar.Drive() 
        {
            Console.WriteLine("Колата е в движение.");
        } */
    }
}
