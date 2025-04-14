using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Cat : Pets
    {
        private string name;
        private int age;
        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override void INFO()
        {
            Console.WriteLine("CAT!!!");
            Console.WriteLine("Името на котката  е {0} и е на {1} години", name, age);
        }
        public override void GetSound()
        {
            Console.WriteLine("MEOW - MEOW");
        }
    }
}
