using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Worker
    {
        public string name;
        public double zaplata;
        public Worker()
        {
            zaplata = 0;
            name = "";
        }
        public Worker(string name, double uspeh)
        {
            this.name = name;
            this.zaplata = uspeh;
        }
        public override string ToString()
        {
            string s = name + "->" + zaplata;
            return s+" лв.";
        }
       
    }
}
