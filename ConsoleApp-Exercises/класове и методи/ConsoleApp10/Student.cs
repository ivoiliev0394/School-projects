using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt_Ivailo_Iliev11A
{ //Ivailo Iliev 11A
    class Student
    {
        private string ime;
        private int klas;
        private char par;
        private double uspeh;

        public Student()
        {
            ime = "";
            klas = 0;
            par = '0';
            uspeh = 0;
        }
        public Student(string ime,int klas, char par,double uspeh)
        {
            this.ime = ime;
            this.klas = klas;
            this.par = par;
            this.uspeh = uspeh;
        }

        public void Information()
        {
            Console.WriteLine("Име={0}, клас={1}, Паралелка={2}, Успех={3:#.##}", ime, klas, par, uspeh);
        }
        public int Klas()
        {
            klas = klas + 1;
            return klas;
        }
        public string IME()
        {
            return ime;
        }
        public double USPEH()
        {
            return uspeh;
        }
        public bool GIMNAZIQ()
        {
            if (klas > 7) return true;
            else return false;
        }

    }
}
