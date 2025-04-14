using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
   public class Person
    {
        private string name;
        private int age;
        private string email;
        public Person(string name, int age, string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
        }
        public void Info()
        {
            Console.WriteLine("Name:{0} Age:{1} Email:{2}", name, age, email);
        }
    }
}
