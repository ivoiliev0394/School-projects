using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    public class Blok2 : ISgradaStroej
    {
        private int brett;
        private double pl;
        private string adres;
        public Blok2(string adres, int brett, double pl)
        {
            this.adres = adres;
            this.brett = brett;
            this.pl = pl;
        }
        public void INFO()
        {
            Console.WriteLine(" Сградата е на адрес {0} с площ {1} кв.м. и брой построени етажи {2}", adres,pl,brett);
        }
        public double OPlost()
        {
            return pl * brett;
        }
        public int CountEtaji()
        {
            return brett;
        }
        public static Blok2 operator ++(Blok2 a)
        {
            a.brett++;
            return a;
        }
    }
}
