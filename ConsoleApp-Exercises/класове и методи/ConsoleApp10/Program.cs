using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt_Ivailo_Iliev11A
{
    class Program
    { //Ivailo Iliev 11A
        static void Main(string[] args)
        {
            Console.Write("Брой ученици=");
            int n = int.Parse(Console.ReadLine());
            Student[] school = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("ИМЕ=");
                string ime = Console.ReadLine();
                int k;
                do
                {
                    Console.Write("Клас=");
                    k = int.Parse(Console.ReadLine());
                } while ( k< 1||k>=12);

                Console.Write("Паралелка-");
                char p = char.Parse(Console.ReadLine());

                double u;
                do
                {
                    Console.Write("Успех=");
                    u = double.Parse(Console.ReadLine());
                } while (u < 3 && u > 6);

                school[i] = new Student(ime, k, p, u);
            }
            Console.WriteLine();
            Console.WriteLine("Информация за учениците!");
            for (int i = 0; i < n; i++)
                school[i].Information();

            Console.WriteLine();
            Console.Write("Име на ученик=");
            string a = Console.ReadLine();
            bool b = false;
            for (int i = 0; i < n; i++)
                if (school[i].IME() == a)
                {
                    b = true;
                    school[i].Information();
                }
            if (b == false) Console.WriteLine("Няма ученик с такова име!");

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                school[i].Klas();
                school[i].Information();
            }

            Console.WriteLine();
            Console.WriteLine("Ученици с най-висок успех от гимназията!");
            bool c = false;
            for (int i = 0; i < n; i++)

            {
                c = true;
                if (school[i].GIMNAZIQ() == c && school[i].USPEH() >= 5.5) school[i].Information();
            }
            if (c == false) Console.WriteLine("Няма  гимназиални ученици с отличен.");

                double min = double.MaxValue;
            for (int i = 0; i < n; i++)
                if (school[i].USPEH() < min) min = school[i].USPEH();
            Console.ReadLine();
            Console.WriteLine("Ученици с най-нисък успех!");
            for (int i = 0; i < n; i++)
                if (min == school[i].USPEH()) school[i].Information();

        }
    }
}
