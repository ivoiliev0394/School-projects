using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Lekaatletika:Sport
    {
        protected string vid;
        public Lekaatletika(string ime, string EGN, string vid) : base(ime, EGN)
        {
            this.vid = vid;
        }
        public override void Info()
        {
            Console.WriteLine("Име:{0}    ЕГН:{1}  Вид:{2}", ime, EGN, vid);
        }
    }
}
