using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Building B1 = new Blok(400, 4, "Лок 5");
            B1.INFO();
           Console.WriteLine();
            Building B2 = new Blok(600, 6, "Лок 6");
            B2.INFO();
            Console.WriteLine();
            Blok.PrintCount();
            Console.WriteLine();
            Console.WriteLine("Сградата с по-голяма площ е:");
            //if (B1 > B2) B1.INFO();
            //else B2.INFO();
           
            Console.WriteLine();
            if (B1 is Building)
            {
                Console.WriteLine("Yes"); B1.INFO();
            }
            else Console.WriteLine("No");
            if (B2 as Building!=null)
            {
                Console.WriteLine("Yes"); B2.INFO();
            }
            else Console.WriteLine("No");
        }
    }
}
