using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r=new Random();
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
      /*      for(int i=0;i<n;i++)
                for(int j=0;j<m;j++)
                {
                    Console.Write("a[{0},{1}]=", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                   // a[i, j] = r.Next(0, 141);
                }       */
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++) 
                { a[i, j] = r.Next(0, 141); Console.Write("|{0,5}", a[i, j]); }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                   Таблицата за умножение!");
            int[,] AxB = new int[11, 11];
            for(int i=0;i<11;i++)
               for(int j=0;j<11;j++)
               {
                    AxB[i, j] = i*j;
               }     
            Console.WriteLine();
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                Console.Write("{0,5}", AxB[i, j]); 
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("                   Главен диагонал");
            for (int i = 0; i < 11; i++)
            {
              Console.Write("{0,5}", AxB[i, i]); 
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("               Извеждане на елементите");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,5}", a[i, i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,5}", a[i,n-1-i]);
            }
            Console.WriteLine();
            Console.WriteLine("Главния диагонал");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                if(i>j)Console.Write("{0,5}", a[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    if (i < j) Console.Write("{0,5}", a[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Обратния диагонал");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    if (i+j<n-1) Console.Write("{0,5}", a[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    if (i + j > n - 1) Console.Write("{0,5}", a[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
