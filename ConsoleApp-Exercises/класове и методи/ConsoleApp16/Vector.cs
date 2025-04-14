using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Vector
    {
        private int x;
        private int y;
        public Vector()
        {
            x = y = 0;
        }
        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Information()
        {
            Console.WriteLine("координти: ( {0} , {1} )", x, y);
        }
        public static Vector operator +(Vector a, Vector b)
        {
            Vector result = new Vector();

            result.x = a.x + b.x;
            result.y = a.y + b.y;
            return result;
        }
    }
}
