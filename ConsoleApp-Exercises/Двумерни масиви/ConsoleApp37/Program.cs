using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
                    NxN[i, j] = r.Next(0, 140);
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
            // 2 zad
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (i < j)
                    { 
                        sum = sum + NxN[i, j];
                        Console.Write(NxN[i, j] + " ");
                    }
            }
            Console.WriteLine();
            Console.WriteLine("sum={0}",sum);
            
            Console.WriteLine();
            Console.WriteLine();
            // 3 zad
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (i + j < n - 1)
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
