using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static int BinarySearch(int[]a,int x)
        {
            int left = 0, right = a.Length - 1;
            while(left<=right)
            {
                int middle = (left + right) / 2;
                if (x > a[middle]) left = middle + 1;
                else if (x < a[middle]) right = middle - 1;
                else return middle;
            }
            return -1;
        }
        static int RecBinSearch(int []a,int x,int left,int right)
        {
            if (left > right) return -1;
            int middle = (left + right) / 2;
            if (x == a[middle]) return middle;
            if (x > a[middle]) return RecBinSearch(a, x, middle + 1, right);
            else return RecBinSearch(a, x, left, middle - 1);
        }
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 6, 7, 12, 16, 23, 26, 34, 56, 66, 78, 80 };
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (BinarySearch(a, x) < 0) Console.WriteLine("Елементът {0} не се съдържа.", x);
            else Console.WriteLine("Елементът {0} се съдържа на  позиция {1}.", x, BinarySearch(a, x));
            Console.WriteLine();
            if (RecBinSearch(a, x,0,a.Length) < 0) Console.WriteLine("Елементът {0} не се съдържа.", x);
            else Console.WriteLine("Елементът {0} се съдържа на  позиция {1}.", x, RecBinSearch(a, x,0,a.Length));
        }
    }
}
