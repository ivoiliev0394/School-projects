using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4 zad 1var
            int k = int.Parse(Console.ReadLine());
            int[,] ss = new int[k, k];
            int a = 1;
            for (int i = 0; i < k; i++)
                for (int j = 0; j < k; j++)
                {
                    ss[i, j] = a;
                    a++;
                }
            Console.WriteLine();
            for (int j = 0; j < k; j++)
            {
                    for (int i = 0; i < k; i++)
                        Console.Write("|{0,5}", ss[i, j]);
                Console.WriteLine();
            }
            // 4 zad 2var
            int[,] s = new int[k, k];
            for (int i = 0; i < k; i++)
                for (int j = 0; j < k; j++)
                {
                    s[i,j ] = (i+1)+(j*k);
                }
            Console.WriteLine();
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                    Console.Write("|{0,5}", s[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            
            // 5 zad
            Random r = new Random();
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[,] NxN = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //Console.Write("NxN[{0},{1}]=", i, j);
                    //NxN[i, j] = int.Parse(Console.ReadLine());
                    NxN[i, j] = r.Next(0, 31);
                    Console.Write("NxN[{0},{1}]={2}", i, j, NxN[i, j]);
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("|{0,3}", NxN[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,5}", NxN[i, i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,5}", NxN[i, n - 1 - i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (i > j)
                    {
                        sum = sum + NxN[i, j];
                        Console.Write(NxN[i, j] + " ");
                    }
            }
            Console.WriteLine();
            Console.WriteLine("sum={0}", sum);
            Console.WriteLine();
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (i + j > n - 1)
                    {
                        sum2 = sum2 + NxN[i, j];
                        Console.Write(NxN[i, j] + " ");
                    }
            }
            Console.WriteLine();
            Console.WriteLine("sum2={0}", sum2);
            Console.WriteLine();

        }
    }
}
