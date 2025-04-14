using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
   public class Student :Person
    {
        private string clas;
        private int nomer;
        public Student(string name, int age, string email, string clas, int nomer) : base(name, age, email)
        {
            this.nomer = nomer;
            this.clas = clas;
        }
        public void Info2()
        {
            base.Info();
            Console.WriteLine("Clas:{0} Nomer: {1}", clas, nomer);
        }
    }
}
