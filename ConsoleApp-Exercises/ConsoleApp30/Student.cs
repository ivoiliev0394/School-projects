using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp30
{
    class Student
    {
        public string name;
        public double uspeh;
        public Student()
        {
            uspeh = 0;
            name = "";
        }
        public Student(string name, double uspeh)
        {
            this.name = name;
            this.uspeh = uspeh;
        }
        public override string ToString()
        {
            string s = name + " има успех " + uspeh;
            return s;
        }
       
    }
}
