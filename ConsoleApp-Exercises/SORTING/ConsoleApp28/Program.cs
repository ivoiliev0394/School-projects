using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void SelectionSort(int[] a)
        {
            for (int i = 0; i < a.Length-1; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        static void SelectionSort2(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        static void SelectionSort(double[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        double temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        static void SelectionSort2(double[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        double temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        static void SelectionSort(string[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i].Length > a[j].Length)
                    {
                        string temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        static void SelectionSort2(string[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i].Length > a[j].Length)
                    {
                        string temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
               //1 zad
               Console.Write("n=");
               int n = int.Parse(Console.ReadLine());
               int[] a = new int[n];
               for (int i = 0; i < n; i++)
               {
                   Console.Write("a[" + i + "]=");
                   a[i] = int.Parse(Console.ReadLine());
               }
               SelectionSort2(a);
               Console.WriteLine();
               for (int i = 0; i < n; i++)
                   Console.Write(a[i] + " ");
               Console.WriteLine();
               SelectionSort(a);
               Console.WriteLine();
               for (int i = 0; i < n; i++)
                   Console.Write(a[i] + " ");
               Console.WriteLine(); Console.WriteLine();
               //2 zad
               Console.Write("l=");
               int l = int.Parse(Console.ReadLine());
               double[] c = new double[l];
               for (int i = 0; i < l; i++)
               {
                   Console.Write("a[" + i + "]=");
                   c[i] = double.Parse(Console.ReadLine());
               }
               SelectionSort(c);
               Console.WriteLine();
               for (int i = 0; i < l; i++)
                   Console.Write(c[i] + " ");
               Console.WriteLine();
               SelectionSort2(c);
               Console.WriteLine();
               for (int i = 0; i < l; i++)
                   Console.Write(c[i] + " ");
               Console.WriteLine(); Console.WriteLine();
            Console.Write("v=");
            int v = int.Parse(Console.ReadLine());
            string[] k = new string[v];
            for (int i = 0; i <v; i++)
            {
                Console.Write("a[" + i + "]=");
                k[i]= Console.ReadLine();
            }
            SelectionSort(k); 
            for (int i = 0; i < v; i++)
              Console.Write(k[i] + " ");
            Console.WriteLine(); Console.WriteLine();
              // 3 zad
               Console.Write("p=");
               int p = int.Parse(Console.ReadLine());
               Random r = new Random();
               int[] b = new int[p];
               for (int i = 0; i < p; i++)
                   b[i] = r.Next(0, 101);
               for (int i = 0; i < p; i++)
                   Console.Write(b[i] + " ");
               SelectionSort(b);
               Console.WriteLine();
               Console.WriteLine();
               for (int i = 0; i < p; i++)
                   Console.Write(b[i] + " ");
               Console.WriteLine(); Console.WriteLine();
        }
    }
}
