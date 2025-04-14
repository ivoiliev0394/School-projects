using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Building s1 = new Blok(300, 5, "Dunav");
            s1.Info();
            if (s1 is Building)
            {
                Console.WriteLine("Yes");
                s1.Info();
            }
            else Console.WriteLine("No");
            Console.WriteLine();
            Blok B1 = new Blok(1000, 7, "Var");
            B1.Info();
            Console.WriteLine("Общата площ е: {0} км.м.", B1.OPlost());
            Blok B2 = new Blok(950,5,"Fan");
            B2.Info();
            Console.WriteLine("Общата площ е: {0} км.м.", B2.OPlost());
            Console.WriteLine();
            Console.WriteLine("По-високият блок е:");
            if (B1 < B2) B2.Info();
            else B1.Info();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            Blok2 B3 = new Blok2("Рим", 5, 200);
            B3.INFO();
            Console.WriteLine("Общата разгърната площ е: {0} км.м.", B3.OPlost());
            Console.WriteLine("Сградата до момента има {0} етажа",B3.CountEtaji());
            B3++;
            B3++;
            B3++;
            Console.WriteLine();
            Console.WriteLine("Блокът вече е построен до {0} етаж", B3.CountEtaji());
            Console.WriteLine();
        }
    }
}
