using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp29
{
    class OtherComparer : IComparer
    {
        public int Comparer(object x,object y)
        {
            int x1 = (int)x;
            int y1 = (int)y;
            int s1 = 0, s2 = 0;
            while (x1 != 0)
            {
                s1 = s1 + x1 % 10;
                x1 = x1 / 10;
            }
            while (y1 != 0)
            {
                s2 = s2 + y1 % 10;
                y1 = y1 / 10;
            }
            if (s1 > s2) return -1;
            else if (s1 < s2) return 1;
            if ((int)x > (int)y) return -1;
            else return 1;
        }
    }
}
