using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Sport
    {
        protected string ime;
        protected string EGN;
        public Sport(string ime, string EGN)
        {
            this.ime = ime;
            this.EGN = EGN;
        }
        public virtual void Info() 
        {
            Console.WriteLine("Име:{0}    ЕГН:{1}",ime,EGN);
        }
    }
}
