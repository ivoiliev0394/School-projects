using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Rectangle k = new Rectangle(a, b);
            k.Info();
            Console.WriteLine("Лицето е:{0}",k.Lice());

            Console.WriteLine();

            Console.Write("a=");
            double aa = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double bb = double.Parse(Console.ReadLine());
            Console.Write("c=");
            double cc = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Paralelepiped p = new Paralelepiped(aa, bb, cc);
            p.Info1();
            Console.WriteLine("Обема е е:{0}", p.Obem());
            Console.WriteLine("Повърхнината е:{0}", p.Povarhnina());
            Console.WriteLine();

        }
    }
}
