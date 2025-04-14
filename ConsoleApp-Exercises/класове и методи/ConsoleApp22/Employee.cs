using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    abstract public class Employee
    {
        protected string ime;
        protected string prof;
        public Employee()
        {
            this.ime = "";
            this.prof = "";
        }
        public Employee(string ime, string prof)
        {
            this.ime = ime;
            this.prof = prof;
        }
        public abstract void INFO();
        public abstract double Zaplata();
       
    }
}
