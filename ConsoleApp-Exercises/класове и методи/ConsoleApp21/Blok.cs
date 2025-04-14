using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
     public class Blok : Building
    {
        private string adress;

        public Blok() : base()
        {
            this.adress = "";

        }
        public Blok(double plost, int bret, string adress) : base(plost, bret)
        {
            this.adress = adress;

        }

        public override void Info()
        {
            Console.WriteLine("Сградата е на площ {0} кв.м. и бр. етажи {1}", plost, bret);
            Console.WriteLine(" Сградата е на адрес: {0}", adress);
        }
        public override double OPlost()
        {
            return plost * bret;
        }

        public static bool operator >(Blok b1, Blok b2)
        {
            if (b1.bret > b2.bret) return true;
            else return false;
        }
        public static bool operator <(Blok b1, Blok b2)
        {
            if (b1.bret < b2.bret) return true;
            else return false;
        }
    }
}
