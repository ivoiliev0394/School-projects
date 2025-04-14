using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivailo11A
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 zad
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            if (a == 0) Console.WriteLine("NOD({0},{1})={1}", a, b);
            if (b == 0) Console.WriteLine("NOD({0},{1})={0}",a,b);
            while(b!=0)
            { 
                int к = a / b;
             int r = a % b;
                a = b;
                b = r;
               
            }
               Console.WriteLine("NOD({0},{1})={0}", a, b);


        }
    }
}
