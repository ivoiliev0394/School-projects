using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Football:Sport
    {
        protected string otbor;
        public Football(string ime, string EGN, string otbor) : base(ime, EGN)
        {
            this.otbor = otbor;
        }
        public override void Info()
        {
            Console.WriteLine("Име:{0}    ЕГН:{1}  Отбор:{2}", ime, EGN, otbor);
        }
    }
}
