using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivailo11a13112020
{
    class Program
    {
        static void Main(string[] args)
        {
            

            double grad = 45;
            Console.WriteLine("Градуси    sin     cos");
            for(double i=grad;i<=90;i=i+2.5)
            {
                double s = Math.Sin(i);
                double c = Math.Cos(i);
                Console.WriteLine("{0:F2}    {1:0.000}    {2:F3}", i, s, c);

            }
            

           

            for(int i=6;i>=1;i--)
            {
                string l = new string(' ', 6 - i);
                Console.Write(l);

                for (int j = 1; j <= i; j++) Console.Write("{0}", i);
                Console.WriteLine();
            }
            

            //Ivailo 11A 3 zad
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            string q;
            int sum = 0;
            for(int i=0;i<m;i++)
            { q = Console.ReadLine();
                int n = int.Parse(q);
                if (n < 20) 
                 sum = sum + n;
               
            } Console.WriteLine("Sum={0}", sum);
            
        }
    }
}
