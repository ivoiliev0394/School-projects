using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static int Sum(int x)
        {
            if (x == 2) return 2;
            else return x + Sum(x - 1);
        }
        static int Fib(int k)
        {
            if (k == 1 || k == 2) return 1;
            else return Fib(k - 1) + Fib(k - 2);
        }
        static int Pow(int m,int n)
        {
            if (n == 0) return 1;
            else return m*Pow(m,n - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            if (x >= 2) Console.WriteLine("Сумата е: " + Sum(x));
            
            Console.WriteLine();

            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());
            if (k >0) Console.WriteLine("{0} елемент на Фабонати е: {1} ",k,Fib(k));

            Console.WriteLine();

            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            if (n >= 0) Console.WriteLine(m+" на "+n+" e: "+Pow(m,n));
        }
    }
}
