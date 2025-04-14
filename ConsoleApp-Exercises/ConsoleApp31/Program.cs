using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static int Search(int[]a,int x)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == x) return i;
                else return -1;
        }
        static int CountSearch(int[] a, int x)
        {
            int br = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] == x)  br++;
            return br;
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] a = new int[50];
            for (int i = 0; i < a.Length; i++)
                a[i] = r.Next(0, 101);
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
            int x;
            do
            {
                Console.Write("x=");
                x = int.Parse(Console.ReadLine());
            } while (x < 0 || x > 100);
            Console.WriteLine();
            if (Search(a, x) == -1) Console.WriteLine("Няма ученик с {0} точки.", x);
            else Console.WriteLine("Има ученик получил {0} точки.", x);
            Console.WriteLine();
            Console.WriteLine("Броят на учениците получили {0} точки е:{1}", x, CountSearch(a, x));
            Console.WriteLine();
        }
    }
}
