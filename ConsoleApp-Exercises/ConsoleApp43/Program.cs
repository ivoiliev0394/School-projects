using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var s = new SortedList<int, string>() { { 9, "Иван" }, { 2, "Лили" }, { 3, "Cлав" } };
            Console.WriteLine(s.Count);
            s.Add(1, "Кирил");
            Console.WriteLine(s[3]);
            Console.WriteLine(s.Count);
            Console.WriteLine("SortedList:");
            for (int i = 0; i < s.Count; i++)
                Console.WriteLine("key:{0} value: {1}", s.Keys[i], s.Values[i]);
            Console.WriteLine();
            foreach (var p in s)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("Ключ със стойност 5 съдържа ли се в списъка? " + s.ContainsKey(5)); //false
            Console.WriteLine("Човек с име Иван съдържа ли се в списъка? " + s.ContainsValue("Иван"));//true
            Console.WriteLine("Позицията на ключ със стойност 5 в списъка е: " + s.IndexOfKey(5));//-1
            Console.WriteLine("Позицията на Иван в списъка е: " + s.IndexOfValue("Иван")); //3
            s.Remove(3); //Слав
            s.RemoveAt(2); //Иван
            foreach (var p in s)
            {
                Console.WriteLine(p);
            } */
            Console.WriteLine("1 zad");
            SortedList<string, int> s = new SortedList<string, int>() { { "Варна", 369162 }, { "Русе", 163712 }, { "Пловдив", 384088 } }; 
            for (int i = 0; i < s.Count; i++)
                Console.WriteLine("{0}  {1}", s.Keys[i], s.Values[i]); 
            Console.WriteLine();
            s.Add("София", 1355142);
            s.Add("Бургас", 226868);
            s.Add("Добрич", 173831);
            foreach (var p in s)
                Console.WriteLine(p);
            Console.WriteLine();
            Console.Write("град:");
            string grad = Console.ReadLine();
            if (s.ContainsKey(grad)) s.Remove(grad);
            else Console.WriteLine("В списъка няма такъв град!");
            Console.WriteLine();
            for (int i = 0; i < s.Count; i++)
                Console.WriteLine("{0}  {1}", s.Keys[i], s.Values[i]);
            Console.WriteLine();
            for (int i = 0; i < s.Count; i++)
                if (s.Values[i] > 300000) Console.WriteLine("{0}  {1}", s.Keys[i], s.Values[i]);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("2 zad");
            SortedList<string, string> k = new SortedList<string, string>() { { "Провадия", "Варна" }, { "Девня", "Варна" }, { "Белослав", "Варна" }, 
                { "Асеновград", "Пловдив" }, { "Карлово", "Пловдив" }, { "Несебър", "Бургас" }, { "Созопол", "Бургас" } };
            for (int i = 0; i < k.Count; i++)
            Console.WriteLine("Област:{0}  Град:{1}", k.Keys[i], k.Values[i]);
            Console.WriteLine();
            Console.Write("град:");
             string grad2 = Console.ReadLine(); Console.WriteLine();
            for (int i = 0; i < k.Count; i++)
                if (k.Values[i] == grad2) Console.WriteLine("{0}  {1}", k.Keys[i], k.Values[i]);
                else Console.WriteLine("В списъка няма такъв град!");
            
            Console.WriteLine();
        }
    }
}
