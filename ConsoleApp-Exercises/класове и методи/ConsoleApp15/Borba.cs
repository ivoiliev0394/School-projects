using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Borba:Sport
    {
        protected string kategoriq;
        public Borba(string ime, string EGN, string kategoriq):base(ime,EGN)
        {
            this.kategoriq = kategoriq;
        }
        public override void Info()
        {
            Console.WriteLine("Име:{0}    ЕГН:{1}  Категория:{2}", ime, EGN,kategoriq);
        }
    }
}
