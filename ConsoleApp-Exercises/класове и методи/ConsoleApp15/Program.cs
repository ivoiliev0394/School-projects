using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Име:");
            string a = Console.ReadLine();
            Console.Write("ЕГН:");
            string b = Console.ReadLine();
            Sport sp = new Sport(a,b);
            sp.Info();
            Console.Write("Категория:");
            string c = Console.ReadLine();
            Borba bor = new Borba(a, b, c);
            bor.Info();
            Console.Write("Отбор:");
            string d = Console.ReadLine();
            Football foot = new Football(a, b, d);
            foot.Info();
            Console.Write("Вид:");
            string e = Console.ReadLine();
            Lekaatletika lek = new Lekaatletika(a, b, e);
            lek.Info();
            Sport t=new Borba(a,b,c);
            Borba k = (Borba)t;
            k.Info();
            if (bor is Borba )
            {
                Console.WriteLine("Yes");
                t.Info();
            }
            else Console.WriteLine("No");

            if (t as Lekaatletika != null)
            {
                Console.WriteLine("Yes");
                t.Info();
            }
            else Console.WriteLine("No");
        }
    }
}
