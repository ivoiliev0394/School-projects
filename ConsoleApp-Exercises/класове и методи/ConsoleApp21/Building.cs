using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    abstract public class Building
    {
        protected double plost;
        protected int bret;
        public Building()
        {
            this.plost = 0;
            this.bret = 0;
        }
        public Building(double plost, int bret)
        {
            this.plost = plost;
            this.bret = bret;
        }
        public abstract void Info();
        public abstract double OPlost();
    }
}
