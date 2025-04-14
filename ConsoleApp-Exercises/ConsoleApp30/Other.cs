using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp30
{
    class Other:IComparer
    {
        public int Compare(object st1, object st2)
        {
            Student s1 = st1 as Student;
            Student s2 = st2 as Student;
            if (string.Compare(s1.uspeh.ToString(), s2.uspeh.ToString()) == 1) return 1;
            else return -1;

        }
    }
}
