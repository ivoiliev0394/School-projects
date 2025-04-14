using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1 zad ");
            List<string> a = Console.ReadLine().Split(' ').ToList();
            for (int i = 0; i < a.Count; i++)
                if (a[i].Substring(0, 1) == "r" || a[i].Substring(0, 1) == "R")
                    Console.Write(a[i] + " ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" 2 zad ");
            List<int> b = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int x = b[b.Count - 1];
            while (b.Contains(x) == true) b.Remove(x);
            Console.WriteLine(string.Join(" ", b));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" 3 zad ");
            List<int> c = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = c.Count - 1; i >= 0; i--)
                if (c[i] < 0) c.RemoveAt(i);
            if (c.Count == 0) Console.WriteLine("Empty");
            else
            {
                c.Reverse();
                Console.WriteLine(string.Join(" ", c));
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" 4 zad ");
            List<string> d = Console.ReadLine().Split(',').ToList();
            for (int i = 0; i < d.Count; i++)
            {
                List<string> res = d[i].Split(' ').ToList();
                res.Reverse();
                Console.WriteLine(string.Join(" ", res));
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" 5 zad ");
            List<int> e = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            e.Sort();
            int br = 1;
            int element = e[0]; 
            for (int i = 1; i < e.Count; i++)
            {
                if (e[i] == element) br++;
                else
                {
                    Console.WriteLine("{0} -> {1}", element, br);
                    element = e[i];
                    br = 1;
                }
            }
            Console.WriteLine("{0} -> {1}", element, br);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" 6 zad ");
            int n, m, k, l;
            List<int> f = new List<int>();
            n = int.Parse(Console.ReadLine());
            f.Add(int.Parse(Console.ReadLine()));
            if (n == 1) return;
            for (k = 2; k <= n; k++)
            {
                m = int.Parse(Console.ReadLine());
                l = 0; while (l < f.Count && m > f[l]) l++;
                if (l == f.Count) f.Add(m);
                else f.Insert(l, m);
            }
            Console.WriteLine(string.Join(" ", f));

        }
    }
}
