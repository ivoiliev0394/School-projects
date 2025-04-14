using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("name-");
            string name = Console.ReadLine();
            Console.Write("age-");
            int age = int.Parse(Console.ReadLine());
            Console.Write("email:");
            string email = Console.ReadLine();
            Console.Write("class=");
            string clas = Console.ReadLine();
            Console.Write("№=");
            int nomer = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Person p = new Person(name, age, email);
            p.Info();
            Console.WriteLine();
            Student st = new Student(name, age, email, clas, nomer);
            st.Info2();
            Console.WriteLine();
           
            /*
            Console.Write("name-");
            string name = Console.ReadLine();
            Console.Write("age-");
            int age = int.Parse(Console.ReadLine());
            Console.Write("email:");
            string email = Console.ReadLine();

            Console.WriteLine();
            Person p = new Person(name, age, email);
            p.Info();
            Console.WriteLine();

            Console.Write("name-");
            string name2 = Console.ReadLine();
            Console.Write("age-");
            int age2 = int.Parse(Console.ReadLine());
            Console.Write("email:");
            string email2 = Console.ReadLine();
            Console.Write("class=");
            string clas = Console.ReadLine();
            Console.Write("№=");
            int nomer = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Student st = new Student(name2, age2, email2, clas, nomer);
            st.Info2();
            Console.WriteLine();
            */
            
        }
    }
}
