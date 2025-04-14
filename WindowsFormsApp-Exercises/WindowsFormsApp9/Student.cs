using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
    class Student
    {
        private string name;
       // static public  count;
        private string a;
        public enum grades { слаб = 2, среден = 3, добър = 4, мн_добър = 5, отличен = 6 };
        public Student(string n, string gr)
        {

            name = n;
           // count++;
            a =gr;
        }
        static public void PrintCount()
        {
          //  Console.WriteLine(Student.count);
        }
        public string INFO()
        {
            return name + " ima " + a;
        }
    }
}
