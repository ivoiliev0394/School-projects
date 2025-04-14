using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        //zad 3
        static int NOD(int a, int b)
        {
            if (a == b) return a;
            else if (a > b) return NOD(a - b, b);
            else return NOD(a, b - a);
        }
        static int NOD2(int a, int b)
        {
            if (b == 0) return a;
            else return NOD2(b, a % b);
        }
        //zad 5
        static int Mult(int a, int b)
        {
            if (a == 1) return b;
            else return Mult(a - 1, b) + b;
        }
        //zad 6
        static void F(int a)
        {
            if (a != 0) { Console.Write(a % 10); F(a / 10); }
        }
        //zad 7
        static void F2(int a)
        {
            if (a != 0) { F2(a / 2); Console.Write(a % 2); }
        }
        //zad 8
        static int Sum(int i, int j)
        {
            if (i > j) return 0;
            else return j + Sum(i, j - 1);
        }
        //zad 9
        static double S(int n)
        {
            if (n == 1) return 1;
            else return Math.Sqrt(n + S(n - 1));
        }
        static double S2(int n)
        {
            double s = 0;
            for (int i = 1; i <= n; i++)
            { s = Math.Sqrt(s + i); }
            return s;
        }
        //zad 10
        static double SUM(double x, int y)
        {
            if (y == 0) return 1;
            else return Math.Pow(x, y) + SUM(x, y - 1);
        }
        static double SUMM(double x, int y)
        {
            double sum = 0;
            for (int i = 0; i <= y; i++)
                sum = sum + Math.Pow(x, i);
            return sum;
        }
        //zad 11
        static int SUM2(int n)
        {
            if (n == 0) return 0;
            else return n * (n + 1) + SUM2(n - 1);

        }
        static int SUM22(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
                s = s + i * (i + 1);
            return s;
        }
        //zad 12
        static long Fact(int n)
        {
            if (n == 0 || n == 1) return 1;
            else return n * Fact(n - 1);
        }
        static int Binom(int n, int k)
        {
            if (k == 0 || k == n) return 1;
            else return Binom(n - 1, k) + Binom(n - 1, k - 1);
        }
        static int IBinom(int n, int k)
        {
            int p = 1;
            for (int i = 1; i <= k; i++)
            {
                p = p * n / i;
                n--;
            }
            return p;
        }
        //zad 13
        static int[] aaa = { 1, 4, -3, 6, 5, 2, -8 };
        static int SumArr(int i, int j)
        {
            if (i > j) return 0;
            else return aaa[j] + SumArr(i, j - 1);
        }
        static int SumArr(int i, int j, int []a)
        {
            if (i > j) return 0;
            else return a[j] + SumArr(i, j - 1);
        }
        static void Main(string[] args)
        {
            
            //zad 4
            int a = 15; int b = 5;
            int a2 = 32; int b2 = 8;
            Console.WriteLine("NOD({0},{1})={2}",a,b,NOD(a, b));
            Console.WriteLine("NOD({0},{1})={2}", a2,b2 ,NOD2(a2, b2));
            //zad 5
            Console.WriteLine("{0} x {1} = {2}", a, b, Mult(a, b));
            //zad 6
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());
            F(c);
            Console.WriteLine();
            //zad 7
            Console.Write("c2=");
            int c2 = int.Parse(Console.ReadLine());
            F2(c2);
            Console.WriteLine();
            //zad 8
            int i = 1;
            int j = 10;
            Console.WriteLine("Sum=" + Sum(i, j));
            //zad 9
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            if (n >= 1) Console.WriteLine("Sum=" + S(n));
            if (n >= 1) Console.WriteLine("Sum=" + S2(n));
            //zad 10
            int x = 2;
            int y = 3;
            Console.WriteLine("Sum="+SUM(x, y));
            Console.WriteLine("Sum=" + SUMM(x, y));
            Console.WriteLine("Sum=" + SUM(x, y) / Math.Pow(x, y));
            Console.WriteLine("Sum=" + SUMM(x, y) / Math.Pow(x, y));
            //zad11
            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum="+SUM2(k));
            Console.WriteLine("Sum=" + SUM22(k)); 
            //zad 12
            int u = 4;
            int g = 3;
            double q = Fact(u) / (Fact(g) * Fact(u - g));
            Console.WriteLine("C({0},{1})={2}", u, g, q);
            Console.WriteLine("C({0},{1})={2}", u, g, Binom(u,g));
            Console.WriteLine("C({0},{1})={2}", u, g,IBinom(u,g));
            //zad 13
            Console.WriteLine("Сумата на елем. от a{0} до a{1} е {2}", 1, 5, SumArr(1, 5));
            int[] bbb = { 1, 5, 6, -7, 8, 9, -5 };
            Console.Write("l=");
            int l = int.Parse(Console.ReadLine());
            Console.Write("z=");
            int z = int.Parse(Console.ReadLine());
            if(l>=0&&z>=l&&z<bbb.Length)
            Console.WriteLine("Сумата на елем. от a{0} до a{1} е {2}", l, z, SumArr(1, 5,bbb));
        }
    }
}
