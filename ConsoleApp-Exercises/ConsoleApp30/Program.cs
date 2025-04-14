using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ConsoleApp30
{ 
    class OtherComparer:IComparer
    {
        public int Compare(object x,object y)
        {
            string s1 = (string)x;
            string s2 = (string)y;
            if (s1.Length > s2.Length) return 1;
            else if (s1.Length < s2.Length) return -1;
            else return string.Compare(s1, s2);
        }
    }
    class Program
    {
        static void SelectionSort(string[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (string.Compare(a[i],a[j])==1)
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
                    if (string.Compare(a[i], a[j]) == -1)
                    {
                        string temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        static void BubbleSort(int []a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length-1-i; j++)
                {
                    if (a[j]>a[j+1])
                    {
                        int temp = a[j];
                        a[j] = a[j+1];
                        a[j+1] = temp;
                    }
                }
            }
        }
        static void BubbleSort2(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - 1 - i; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            /*
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            string[] s = new string[n];
            for(int i=0;i<s.Length;i++)
            {
                Console.Write("Ime=");
                s[i] = Console.ReadLine();
            }
            IComparer comp = new OtherComparer();
            Array.Sort(s, comp);
            //SelectionSort(s);
            //Array.Sort(s);
            for (int i = 0; i < s.Length; i++)
                Console.Write(s[i] + " ");
            Console.WriteLine();  */

            /*
            StreamReader sr = new StreamReader(@"E:\daswkalo\IT\ConsoleApp30\zad1.txt");
            StreamWriter sw = new StreamWriter(@"E:\daswkalo\IT\ConsoleApp30\zad2.txt");
            int [] s=sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < s.Length; i++)
                Console.Write(s[i] + " ");
            BubbleSort(s);
            Console.WriteLine();
            for (int i = 0; i < s.Length; i++)
            { Console.Write(s[i] + " "); sw.Write(s[i] + " "); }
            Console.WriteLine();
            sr.Close();
            sw.Close();
            */

            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            Student[] st = new Student[m];
            for(int i=0;i<m;i++)
            {
                st[i] = new Student();
                st[i].name = Console.ReadLine();
                st[i].uspeh = double.Parse(Console.ReadLine());
               
            } 
            IComparer comp = new Other();
            Array.Sort(st, comp);
            for (int i = 0; i < st.Length; i++)
                 Console.WriteLine(st[i] + " ");
        }
    }
}
