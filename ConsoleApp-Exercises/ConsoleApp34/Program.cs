using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp34
{
    class Ccomparer:IComparer
    {
        public int Compare(object x,object y)
        {
            Worker work1 = x as Worker;
            Worker work2 = y as Worker;
            if (string.Compare(work1.zaplata.ToString(), work2.zaplata.ToString()) != 1) return 1;
            else return -1;
        }
    }
    class Program
    {
        static int Search(string a, Worker [] w)
        {
            for (int i = 0; i < w.Length; i++)
                if (w[i].name == a) return i;
            return -1;
        }
        
        static void Main(string[] args)
        {
           
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Worker[] w = new Worker[n];
            for (int i = 0; i < w.Length; i++)
            {
                w[i] = new Worker();
                Console.Write("Име: ");
                w[i].name = Console.ReadLine();
                Console.Write("Заплата=");
                w[i].zaplata = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < w.Length; i++)
                Console.WriteLine(w[i].ToString());
            Console.WriteLine();
            IComparer comp = new Ccomparer();
            Array.Sort(w, comp);
            for (int i = 0; i < w.Length; i++)
                Console.WriteLine(w[i] + " ");
            Console.WriteLine();
            Console.Write("Име-");
            string s = Console.ReadLine();
            if (Search(s, w) != -1) Console.WriteLine(" {0} е елемент на масива и е на позиция {1}", s, Search(s, w));
            else Console.WriteLine(" {0} не се съдържа в масива", s);
            Console.WriteLine();


        }
    }
}
