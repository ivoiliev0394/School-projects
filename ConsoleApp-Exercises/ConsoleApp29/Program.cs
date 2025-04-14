using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp29
{ 
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] z = {23,112,14,122,34,134,8,12 };
            /* Array.Sort(z);
             for (int i = 0; i < z.Length; i++)
                 Console.Write(z[i] + " ");*/
            /*Array.Sort(z,1,5);
            for (int i = 0; i < z.Length; i++)
                Console.Write(z[i] + " ");*/
            IComparer cmp = new OtherComparer();
            Array.Sort(z, cmp);
            for (int i = 0; i < z.Length; i++)
                Console.Write(z[i] + " ");
        }
    }
}
