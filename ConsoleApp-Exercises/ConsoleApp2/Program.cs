using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivailo_11A
{ 
    class Program
    {
        static void Main(string[] args)
        {
           
            //2zad a)  

            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());
            int maxN = int.MinValue;
            for (int i = 1; i <= k; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > maxN) maxN = number;
            }
            Console.WriteLine("Max:{0}", maxN);



            //2zad b)
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int miN = int.MaxValue;
            for (int p = 1; p <= n; p++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < miN) miN = number;
            }
            Console.WriteLine("Min:{0}", miN);


            //3zad

            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            if (m > 1)
              {
                for (int d = 1; d <= (Math.Sqrt(m)+1); d++)
                    if (m % d != 0) 
                        Console.WriteLine("Числото {0} е просто", m);
               }
            
            //4
            int j = 2;
            int e;
            for (e = 0; e <= 49; e++)
                Console.WriteLine(Math.Pow(j, e));

        }
    }
}
