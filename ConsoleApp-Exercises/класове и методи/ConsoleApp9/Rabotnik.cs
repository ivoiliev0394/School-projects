using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivailo11A
{
    class Rabotnik
    {
        private string ime;
        private int staj;
        private double zaplata;

        public Rabotnik()
        {
            ime = "";
            staj = 0;
            zaplata = 0;
        }

        public Rabotnik(string ime, int staj,double zaplata)
        {
            this.ime = ime;
            this.staj = staj;
            this.zaplata = zaplata;
        }

        public double Bonus(double x)
        {
            zaplata = zaplata + x;
            return zaplata;
        }

        public int Staj()
        {
            staj = staj + 1;
            return staj;
        }

        public void Information()
        {
            Console.WriteLine("име--{0},    трудов стаж={1},    заплата={2:C}", ime, staj, zaplata);
        }
        public string IME()
        {
            return ime;
        }

        public double Zaplata()
        {
            return zaplata;
        }

        public bool SREDENStaj()
        {
            if (staj >= 10) return true;
            else return false;
        }
    }
}
