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
            Rectanglel r = new Rectanglel();
            r.Information();
            Console.WriteLine();
            double a, b;
            do
            {
                Console.Write("Страна а=");
                a = double.Parse(Console.ReadLine());
            } while (a <= 0);

            do
            {
                Console.Write("Страна b=");
                b= double.Parse(Console.ReadLine());
            } while (b <= 0);

            Rectanglel r1 = new Rectanglel(a, b);
            r1.Information();
            Console.WriteLine("Лицето на правоъгълника е:{0:F2}", r1.Lice());
            Console.WriteLine("Обиколката на правоъгълника е:{0:F2}", r1.Perim());
            if (r1.Sravnenie()) Console.WriteLine("Този правоъгълник е с равни страни, т.е. е квадрат.");
            else Console.WriteLine("Правоъгълник е.");
            Console.WriteLine();

            //Правоъгълник със страни увеличени с 3см
            Rectanglel r2 = new Rectanglel(a+3, b+3);
            r2.Information();
            Console.WriteLine("Лицето на правоъгълника е:{0:F2}", r2.Lice());
            Console.WriteLine("Обиколката на правоъгълника е:{0:F2}", r2.Perim());
            if (r2.Sravnenie()) Console.WriteLine("Този правоъгълник е с равни страни, т.е. е квадрат.");
            else Console.WriteLine("Правоъгълник е.");
            Console.WriteLine();

            //Правоъгълник със страни увеличени с 5см и 3см
            Rectanglel r3 = new Rectanglel(a + 5, b + 3);
            r3.Information();
            Console.WriteLine("Лицето на правоъгълника е:{0:F2}", r3.Lice());
            Console.WriteLine("Обиколката на правоъгълника е:{0:F2}", r3.Perim());
            if (r3.Sravnenie()) Console.WriteLine("Този правоъгълник е с равни страни, т.е. е квадрат.");
            else Console.WriteLine("Правоъгълник е.");
            Console.WriteLine();

            Rectanglel r4 = new Rectanglel(r1);
            r4.Information();
        }
    }
}
