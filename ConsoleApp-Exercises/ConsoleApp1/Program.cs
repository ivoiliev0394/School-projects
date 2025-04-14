using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 12;
            if (b % 5 != 3 &&  a/b == 0)
{
                a = a - b++;
                b = b + 2;
            }
else { b = a - b; }
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
