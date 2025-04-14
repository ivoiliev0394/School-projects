using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    public class Worker : Employee
    {
        private int trst;
        private double zapl;
        public static int count;
        public Worker(string ime, string prof, int trst, double zapl) : base(ime, prof)
        {
            this.trst = trst;
            this.zapl = zapl;
            count++;
        }
        public override void INFO()
        {
            Console.WriteLine("Име: {0}  Професия: {1}  Трудов стаж: {2}  Заплата: {3} лв.", ime, prof, trst, zapl);
        }
        public static void PrintCount()
        {
            Console.WriteLine("Броят на работниците е :{0}", count);
        }
        public override double Zaplata()
        {
            if (trst >= 10) return zapl + 100;
            else return zapl;
        }
        public static bool operator >(Worker a, Worker b)
        {
            if (a.zapl > b.zapl) return true;
            else return false;
        }
        public static bool operator <(Worker a, Worker b)
        {
            if (a.zapl < b.zapl) return true;
            else return false;
        }
        public int TrStaj()
        {
            return trst;
        }
        public static Worker operator ++(Worker a)
        {
            a.trst++;
            return a;
        }
    }
}
