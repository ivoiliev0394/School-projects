using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class Blok : Building
    {
        private string adress;
        public static int count;
        public Blok(double area,int etaji, string adress):base(area,etaji)
        {
            this.adress = adress;
            count++;
        }
        public override void INFO()
        {
            base.INFO();
            Console.WriteLine(" Сградата е на адрес: {0}", adress);
        }
        public static void PrintCount()
        {
            Console.WriteLine("Броят на блоковете е :{0}", count);
        }
    }
}
