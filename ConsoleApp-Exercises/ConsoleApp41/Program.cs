using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 4, -5, 7, -3, 2, 9 };
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine("list[{0}]={1}", i, list[i]);
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", list));

            Console.WriteLine();Console.WriteLine();

            Console.WriteLine("  2 зад");
            List<string> a = Console.ReadLine().Split(' ').ToList();
            Console.WriteLine(string.Join(", ", a));
            a.Sort();
            a.Reverse();
            Console.WriteLine(string.Join(", ", a));

            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("  3 зад");
            List<int> aa = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> b = new List<int>();
            for (int i = 0; i < aa.Count; i++)
                if (aa[i] % 2 == 0) b.Add(aa[i]);
            Console.WriteLine(string.Join(", ", aa));
            Console.WriteLine(string.Join(", ", b));
            Console.WriteLine();
        }
    }
}
