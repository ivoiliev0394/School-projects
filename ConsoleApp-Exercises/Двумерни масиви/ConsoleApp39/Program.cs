using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] s = { { 6.5, -2.8, 5.25, 8.3 }, { 0.25, 20.2, -3.25, -2.3 }, { 5.5, 10.5, 15.7, 3.7 } };
            
                        //1a
                        double pr = 1;
                        for (int i = 0; i < 3; i++)
                            for (int j = 0; j < 4; j++)
                                if (s[i, j] < 0) pr = pr * s[i, j];
                        Console.WriteLine("pr={0}", pr);
                        Console.WriteLine();
                        //1b
                        int count = 0;
                        for (int i = 0; i < 3; i++)
                            for (int j = 0; j < 4; j++)
                                if (s[i, j] > 0) count++;
                        Console.WriteLine("broi={0}", count);
                        Console.WriteLine();
                        //1B
                        for (int i = 0; i < 3; i++)
                            for (int j = 0; j < 4; j++)
                                if (s[i, j] > 2.5&& s[i,j]<=10.5) Console.WriteLine(s[i,j]);
                        Console.WriteLine();
                        //1g
                       for (int j = 0; j < 4; j++)
                        {
                            double sum = 0;
                            for (int i = 0; i < 3; i++)
                                sum = sum + s[i, j]; 
                            Console.WriteLine("sum={0}", sum);
                        }
                        Console.WriteLine();
                        Console.WriteLine();

                        // 2 zad
                        Console.Write("k=");
                        int k = int.Parse(Console.ReadLine());
                        int[,] s2 = new int[k, k];
                        for (int i = 0; i < k; i++)
                            for (int j = 0; j < k; j++)
                            {
                                s2[i, j] = (i + 1) + (j * k);
                            }
                        Console.WriteLine();
                        for (int i = 0; i < k; i++)
                        {
                            for (int j = 0; j < k; j++)
                                Console.Write("|{0,5}", s2[i, j]);
                            Console.WriteLine();
                        }
                        Console.WriteLine();

        }
    }
}
