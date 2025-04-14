using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void BubbleSort(int []a)
        {
          int n=a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
                }
            }
        }
        static void BubbleSort2(int []a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        int tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
                }
            }
        }
        static void BubbleSort(double[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        double tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
                }
            }
        }
        static void BubbleSort2(double[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        double tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //1zad-1vi variant
            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());
            int[] z = new int[k];
            for (int i = 0; i < k; i++)
            {
                Console.Write("a[" + i + "]=");
                z[i] = int.Parse(Console.ReadLine());
            }
            int d = z.Length;
            for (int i = 0; i < d - 1; i++)
            {
                for (int j = 0; j < d - 1 - i; j++)
                {
                    if (z[j] > z[j + 1])
                    {
                        int tmp = z[j];
                        z[j] = z[j + 1];
                        z[j + 1] = tmp;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < k; i++)
                Console.Write(z[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < d - 1; i++)
            {
                for (int j = 0; j < d - 1 - i; j++)
                {
                    if (z[j] < z[j + 1])
                    {
                        int tmp = z[j];
                        z[j] = z[j + 1];
                        z[j + 1] = tmp;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < k; i++)
                Console.Write(z[i] + " ");
            Console.WriteLine();
            Console.WriteLine();

             //1zad-2ri variant
             Console.Write("n=");
             int n = int.Parse(Console.ReadLine());
             int[] a = new int[n];
             for (int i = 0; i < n; i++)
             {
                 Console.Write("a[" + i + "]=");
                 a[i] = int.Parse(Console.ReadLine());
             }
             BubbleSort(a);
             Console.WriteLine();
             for (int i = 0; i < n; i++)
                 Console.Write(a[i]+" ");
             Console.WriteLine();
             BubbleSort2(a);
             Console.WriteLine();
             for (int i = 0; i < n; i++)
                 Console.Write(a[i] + " ");
             Console.WriteLine();
             Console.WriteLine();

            // 2 zad
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            int[] b = new int[m];
            for (int i = 0; i < m; i++)
            {
                Console.Write("a[" + i + "]=");
                b[i] = int.Parse(Console.ReadLine());
            }
            BubbleSort(b);
            Console.WriteLine();
            for (int i = 0; i < m; i++)
                Console.Write(b[i] + " ");
            Console.WriteLine();
            Console.WriteLine();

            // 3 zad
            Console.Write("l=");
            int l = int.Parse(Console.ReadLine());
            double[] c = new double[l];
            for (int i = 0; i < l; i++)
            {
                Console.Write("a[" + i + "]=");
                c[i] = double.Parse(Console.ReadLine());
            }
            BubbleSort2(c);
            Console.WriteLine();
            for (int i = 0; i < l; i++)
                Console.Write(c[i] + " ");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
