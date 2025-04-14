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
            Console.Write("Брой работници=");
            int n = int.Parse(Console.ReadLine());
            Rabotnik[] firma = new Rabotnik[n];

            for(int i=0;i<n;i++)
            {
                Console.Write("ИМЕ=");
                string ime = Console.ReadLine();
                int s;
                do
                {
                    Console.Write("Трудов стаж=");
                    s = int.Parse(Console.ReadLine());
                } while (s <= 0);

                double z;
                do
                {
                    Console.Write("Заплата=");
                    z = double.Parse(Console.ReadLine());
                } while (z < 400); //min zaplata 400

                firma[i] = new Rabotnik(ime, s, z);
            }

            Console.WriteLine();
            Console.WriteLine("Информация за работниците:");
            for (int i = 0; i < n; i++)
                firma[i].Information();

            Console.WriteLine();
            double x;
            do
            {
                Console.Write("Коледен бонус=");
                x = double.Parse(Console.ReadLine());
            } while (x < 0);
            for(int i=0;i<n;i++)
            if(firma[i].SREDENStaj())
                {
                Console.WriteLine("Заплатата на {0} за Коледа ще бъде {1:C2}", firma[i].IME(), firma[i].Bonus(x));
                }
            Console.WriteLine();
            Console.Write("Име на работник=");
            string a = Console.ReadLine();
            bool b = false;
            for (int i = 0; i < n; i++)
                if(firma[i].IME()==a)
                {
                    b = true;
                 Console.WriteLine("Трудовия стаж на {0} вече е {1} години", a, firma[i].Staj());
                 Console.WriteLine("Заплатата на {0} за празника е {1:C2}", a, firma[i].Bonus(60));
                }
            if (b == false) Console.WriteLine("Няма работник с търсеното име!");

            double min = double.MaxValue;
            for (int i = 0; i < n; i++)
                if (firma[i].Zaplata() < min) min = firma[i].Zaplata();
            Console.ReadLine();
            Console.WriteLine("Работници с най-ниска заплата:");
            for (int i = 0; i < n; i++)
                if (min == firma[i].Zaplata()) firma[i].Information();
        }
    }
}
