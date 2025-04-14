using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Klimatik
    { //Ivailo 11A
        private string marka;
        private double cena;
        private int kol;
        public Klimatik()
        {
            marka = "";
            cena = 0;
            kol = 0;
        }
        public Klimatik(string marka, double cena, int kol)
        {
            this.marka = marka;
            this.cena = cena;
            this.kol = kol;
        }
        public int PROD(int n)
        {
            kol = kol - n;
            return kol;
        }

        public int DOST(int n)
        {
            kol = kol + n;
            return kol;
        }
        public void INFO()
        {
            Console.WriteLine("Климатик-{0}, цена-{1}, количество-{2}", marka,cena,kol);
        }
        public int Kolichestvo()
        { return kol; }
        public string MARKA()
        { return marka ; }
        public double CENA()
        { return cena; }
        public bool INFO2()
        { if (kol == 0) return true;
          return false; 
        }



    }
}
