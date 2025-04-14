using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ArrayList st = new ArrayList();
            //var st=new ArrayList();
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.Write("name:");
                string name = Console.ReadLine();
                st.Add(name);

            }
            Console.WriteLine();
            st.Sort();
            for (int i = 0; i < n; i++)
                Console.WriteLine("{0} {1}", (i + 1), st[i]);
            Console.WriteLine();
             */
            var av = new ArrayList();
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("marka:");
                string marka = Console.ReadLine();
                av.Add(marka);
                Console.Write("model:");
                string model = Console.ReadLine();
                av.Add(model);
                Console.Write("cena=");
                double cena =double.Parse(Console.ReadLine());
                av.Add(cena);
                Console.Write("br=");
                int br = int.Parse(Console.ReadLine());
                av.Add(br);
                Console.WriteLine();
            }
            Console.WriteLine(av.Count);
            for (int i = 0; i < av.Count; i++)
            {
                if (i != 0 && i % 4 == 0) Console.WriteLine();
                Console.Write(av[i] + " ");
            }
            Console.WriteLine();
      
        }
    }
}
