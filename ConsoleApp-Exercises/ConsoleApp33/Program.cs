using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void TrivialMerge(int n1,int[]a,int n2,int[]b)
        {
            int[] c = new int[n1 + n2];
            for (int i = 0; i < n1; i++)
                c[i] = a[i];
            for (int i = 0; i < n2; i++)
                c[i + n1] = b[i];
            Array.Sort(c);
            for (int i = 0; i < c.Length; i++)
                Console.Write(c[i] + " ");
        }
        static void MergeSort(int n1, int[] a, int n2, int[] b)
        {
            int m1 = 0, m2 = 0, n;
            n = n1 + n2;
            int[] c = new int[n];
            for(int i=0;i<n;i++)
            {
                if(m1<n1&&m2<n2)
                {
                    if(a[m1]<=b[m2]) { c[i] = a[m1]; m1++; }
                    else { c[i] = b[m2]; m2++; }
                }
                else
                {
                    if(m1<n1) { c[i] = a[m1]; m1++; }
                    else { c[i] = b[m2]; m2++; }
                }
            }
            for (int i = 0; i < c.Length; i++)
                Console.Write(c[i] + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 6, 13, 15, 23, 45, 67, 88 };
            int[] b = { 2, 6, 15, 16, 18, 22, 23, 34, 45, 75, 99, 100, 100, 101 };
            int n1 = a.Length;
            int n2 = b.Length;
            Console.WriteLine("TrivialMerge");
            TrivialMerge(n1, a, n2, b);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("MergeSort");
            MergeSort(n1, a, n2, b);
            Console.WriteLine();

        }
    }
}
