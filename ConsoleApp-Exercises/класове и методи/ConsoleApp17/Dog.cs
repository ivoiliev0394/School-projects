using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Dog : Pets
    {
        private string name;
        private int age;
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override void INFO()
        {
            Console.WriteLine("DOG!!!");
            Console.WriteLine("Името на кучето е {0} и е на {1} години",name,age);
        }
        public override void GetSound()
        {
            Console.WriteLine("WOOF - WOOF");
        }
    }
}
