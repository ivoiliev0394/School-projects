using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {    //Ivailo 11A
            Console.Write("Видове климатици=");
            int k = int.Parse(Console.ReadLine());
            Klimatik[] kl = new Klimatik[k];
            for (int i = 0; i < k; i++)
            {
                Console.Write("marka=");
                string m = Console.ReadLine();
                double cena;
                do
                {
                    Console.Write("cena=");
                    cena = double.Parse(Console.ReadLine());
                } while (cena <= 0);
                int kol;
                do
                {
                    Console.Write("kolichestvo=");
                    kol = int.Parse(Console.ReadLine());
                } while (kol <= 0);
                kl[i] = new Klimatik(m, cena, kol);
            }
            Console.WriteLine("Информация за климатиците:");
            for (int i = 0; i < k; i++) kl[i].INFO();

            for(int i = 0; i < k; i++)
                if(kl[i].MARKA()=="Fujitsu")
                {
                    int n;
                    do
                    {
                        Console.Write("Dostaveni=");
                        n = int.Parse(Console.ReadLine());
                    } while (n < 0);
                    Console.WriteLine("Броя на климатицоте от Fujitsu-"+kl[i].DOST(n));
                }
            for (int i = 0; i < k; i++) kl[i].INFO();

            Console.WriteLine("Инфо за климатици от марка-от клавиатурата");
            Console.Write("marka=");
            string mar = Console.ReadLine();
            bool b = false;
            for (int i = 0; i < k; i++)
                if (kl[i].MARKA() == mar) { b = true; kl[i].INFO(); }
            if(b==false) Console.WriteLine("Няма такива климатици!");

            for (int i = 0; i < k; i++)
                if (kl[i].MARKA() == mar)
                {
                    int n;
                    do
                    {
                        Console.Write("Dostaveni=");
                        n = int.Parse(Console.ReadLine());
                    } while (n < 0);
                    int l;
                    do
                    {
                        Console.Write("Prodadeni=");
                        l = int.Parse(Console.ReadLine());
                    } while (l < 0 );
                    Console.WriteLine("Броя на климатиците от {0}-{1}",kl[i].MARKA(), kl[i].DOST(n));
                    Console.WriteLine("Броя на климатиците от {0} след продажбата-{1}", kl[i].MARKA(), kl[i].PROD(l));
                }
            for (int i = 0; i < k; i++) kl[i].INFO();
            
            Console.WriteLine();
            Console.WriteLine("Инфо за климатиците - най-скъп.");
            int max = int.MinValue;
            for (int i = 0; i < k; i++)
                if (max < kl[i].Kolichestvo()) max = kl[i].Kolichestvo();
            for (int i = 0; i < k; i++) if(max==kl[i].Kolichestvo()) kl[i].INFO();
           
            /*// da izvede  za vsichki
            Console.WriteLine();
            Console.WriteLine("Инфо за климатиците - най-скъп.");
            int max = int.MinValue;
            for (int i = 0; i < k; i++)
                if (max < kl[i].Kolichestvo()) max = kl[i].Kolichestvo();
            for (int i = 0; i < k; i++) kl[i].INFO();
            */




            /*//Bez masiv
             *Klimatik r = new Klimatik(m,cena,kol) ;
            r.INFO();
            int n;
            do
            {
                Console.Write("Dostaveni=");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            Console.WriteLine("Broi sled dostavka={0}", r.DOST(n));
            r.INFO();
            do
            {
                Console.Write("Prodadeni=");
                n = int.Parse(Console.ReadLine());
            } while (n < 0 || n > r.Kolichestvo());
            Console.WriteLine("Broi sled prodadeni={0}", r.PROD(n));
            r.INFO();
            Console.WriteLine(r.MARKA());
            Console.WriteLine(r.CENA());
            Console.WriteLine(r.Kolichestvo());
            if (r.INFO2() == true) Console.WriteLine("Nqma ostanali broiki");
            else Console.WriteLine("Ima v nalichnost");
        */
        }

    }
}

