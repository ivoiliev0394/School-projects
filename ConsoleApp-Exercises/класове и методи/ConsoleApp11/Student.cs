using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Student
    {
        private string name;
        static public int count;
        private grades a;
        public enum grades { слаб = 2, среден = 3, добър = 4, мн_добър = 5, отличен = 6 };
        public Student(string n, int gr)
        {

            name = n;
            count++;
            a = (grades)gr;
        }
        static public void PrintCount()
        {
            Console.WriteLine(Student.count);
        }
        public void INFO()
        {
            Console.WriteLine(name +" ima "+ a);
        }
    }
}
