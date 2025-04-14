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
            for (int i = 6; i >= 1; i--)
            {
                for (int j = 6; j >= i; j--) Console.Write("{0,2}", j);
                Console.WriteLine();
            }
        }
    }
}
