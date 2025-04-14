using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person("Иван", 17);
            Person b = new Person("Ива", 16);
            a.INFO();
            b.INFO();
            Console.WriteLine();
            Person c;
            c = a ++;
            c.INFO();
            Console.WriteLine();
            Person d;
            d = b++;
            d.INFO();
            Console.WriteLine();
            if (d<c) Console.WriteLine(c.IME() +" е по-голям от "+d.IME());
            else if (d > c) Console.WriteLine(d.IME() + " е по-голям от " + c.IME());
            else Console.WriteLine("Nabori sa");
            
      

            /*
            Vector a = new Vector(2, 2);
            Vector b = new Vector(4, 1);
            Console.WriteLine("вектор а е с ");
            a.Information();
            Console.WriteLine("вектор b е с ");
            b.Information();
            Console.WriteLine();
            Vector c;
            c = a + b;
            Console.WriteLine("a + b e с ");
            c.Information();
            */
        }
    }
}
