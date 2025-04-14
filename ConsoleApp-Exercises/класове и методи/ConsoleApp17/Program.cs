using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure F1 = new Triangle(5, 8);
            F1.INFO();
            Console.WriteLine("S на триъгълника е: {0} кв.м.", F1.Area());
            Console.WriteLine();
            Figure F2 = new Rectangle(10, 8);
            F2.INFO();
            Console.WriteLine("S на правоъгълника е: {0} кв.м.", F2.Area());
            Console.WriteLine();
            Figure F3 = new Comparator(6, 8);
            F3.INFO();
            Console.WriteLine("S на успоредника е: {0} кв.м.", F3.Area());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Pets P1 = new Dog("Рекс", 5);
            P1.INFO();
            P1.GetSound();
            Console.WriteLine();
            Pets P2 = new Cat("Ниа", 3);
            P2.INFO();
            P2.GetSound();
            Console.WriteLine();

        }
    }
}
