using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            string[] studName = { "Александър", "Диана", "Мартин" };
            string[] studPr = { "БЕЛ", " Чужд език", "Математика", "Информатика", "ИТ" };
            int n = studName.Length;
            int m = studPr.Length;
            int[,] a = new int[n, m];
            for(int i=0;i<n;i++)
            {
                for (int j = 0; j < m; j++)
                {
                    //Console.Write("students[{0},{1}]=", i, j);
                    //a[i, j] = int.Parse(Console.ReadLine());
                     a[i, j] = r.Next(2,7);
                    Console.Write("students[{0},{1}]={2}", i, j, a[i,j]);
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write("|{0,3}", a[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();

            int max = int.MinValue, nums = 0;
            for(int i=0;i<n;i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++) 
                    sum = sum + a[i, j];
                if(sum>max)
                {
                    max = sum; nums = i;
                }
            }
            for(int i=0;i<studName.Length;i++)
                if(nums==i)
                {
                   Console.WriteLine(studName[i]);
                   Console.WriteLine((nums + 1) + " е с най-висок успех");
                }
            int min = int.MaxValue, nums1 = 0;
             for (int i = 0; i < n; i++)
             {
                 int sum = 0;
                 for (int j = 0; j < m; j++)
                    sum = sum + a[i, j];
                 if (sum < min)
                 {
                     min = sum; nums1 = i;
                 }
             }
             for (int i = 0; i < studName.Length; i++)
                 if (nums1 == i)
                 {
                     Console.WriteLine(studName[i]);
                     Console.WriteLine((nums1 + 1) + " е с най-нисък успех");
                 }   

            Console.WriteLine();
            Console.WriteLine();

            int minpr = int.MaxValue, nums2 = 0;
            for (int j = 0; j < m; j++)
            {
                int sum = 0;
                for (int i = 0; i < n; i++)
                    sum = sum + a[i, j];
                if (sum < minpr)
                {
                    minpr = sum; nums2 = j;
                }
            }
            for (int i = 0; i < studPr.Length; i++)
                if (nums2 == i)
                {
                    Console.WriteLine(studPr[i]);
                    Console.WriteLine((nums2 + 1) + " е с най-нисък успех");
                }

            Console.WriteLine();

            int maxpr = int.MinValue, nums3 = 0;
            for (int j = 0; j < m; j++)
            {
                int sum = 0;
                for (int i = 0; i < n; i++)
                    sum = sum + a[i, j];
                if (sum > maxpr)
                {
                    maxpr = sum; nums3 = j;
                }
            }
            for (int i = 0; i < studPr.Length; i++)
                if (nums3 == i)
                {
                    Console.WriteLine(studPr[i]);
                    Console.WriteLine((nums3 + 1) + " е с най-висок успех");
                }

            Console.WriteLine();
            Console.WriteLine(); 
        }
    }
}
