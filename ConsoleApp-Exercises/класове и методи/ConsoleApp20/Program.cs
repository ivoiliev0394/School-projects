using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6 ot 49");
            Toto t1 = new Toto(6, 49);
            t1.Draw();
            Console.WriteLine();

            Console.WriteLine(t1);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("5 ot 65");
            Toto t2 = new Toto(5, 65);
            t2.Draw();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("6 ot 36");
            Toto t3 = new Toto(6, 36);
            t3.Draw();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("1 ot 16");
            Toto t4 = new Toto(1, 16);
            t4.Draw();

            Console.WriteLine();
        }
    }
}
