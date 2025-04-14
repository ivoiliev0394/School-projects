using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Person
    {
        private string name;
        private int age;
        public Person()
        {
            this.name = "";
            this.age = 0;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void INFO()
        {
            Console.WriteLine("{0} е на {1}", name, age);
        }
        public string IME()
        {
            return name;
        }
        public static Person operator ++(Person a)
        {
            Person result = new Person();
            result.age = a.age++;
            return result;
        }
        public static bool operator <(Person a, Person b)
        {
            if (a.age < b.age) return true;
            else return false;
        }
       public static bool operator >(Person a, Person b)
        {
            if (a.age > b.age) return true;
            else return false;
        }
    
    }
}
