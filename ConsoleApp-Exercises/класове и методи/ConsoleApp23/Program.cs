using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum s = new Sum();
            Console.WriteLine(s.Add(2, 4));
            Console.WriteLine(s.Add(22, 44,4));
            Console.WriteLine(s.Add(2.5, 4.5));
            Console.WriteLine(s.Add("bum", "bum"));

            Console.WriteLine(); Console.WriteLine();

            Home h = new Home(120);
            Console.WriteLine("Цената на жилището е: {0} евро.",h.Cena());
            House h1 = new House(120, 500);
            Console.WriteLine("Цената на къщата с дворното място е: {0} евро", h1.Cena());

            Console.WriteLine(); Console.WriteLine();

            int a = 25, b = 55;
            Console.WriteLine(a);
            Console.WriteLine(a.Equals(b));
            Console.WriteLine();
            Point p = new Point(20, 30);
            Console.WriteLine(p);
            Point p1 = new Point(20, 30);
            Point p2 = new Point(120, 30);
            Console.WriteLine(p.Equals(p1));
            Console.WriteLine(p.Equals(p2));
        }
    }
}
