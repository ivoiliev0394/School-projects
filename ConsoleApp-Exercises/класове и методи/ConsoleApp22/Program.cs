using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee s1 = new Worker("Ivo","Doctor",8,900);
            s1.INFO();
            if (s1 is Employee)
            {
                Console.WriteLine("Yes");
                s1.INFO();
            }
            else Console.WriteLine("No");
            Console.WriteLine();
            Worker W1 = new Worker("Ivan", "Doctor", 9, 1000);
            W1.INFO();
            Worker W2 = new Worker("Iva", "Programmer", 10, 1200);
            W2.INFO();
            Worker.PrintCount();
            W1++;
            W1.INFO();
            Console.WriteLine(W1.Zaplata());
            Console.WriteLine();
            Console.WriteLine("Работника с по-голяма заплата е:");
            if (W1 < W2) W2.INFO();
            else W1.INFO();

        }
    }
}
