using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
   static class Sphere
    {
        static private double pi = 3.14;
        static public double Surface(double R)
        { return 4 * pi * R * R; }
        static public double Volume(double R)
        { return (4 * pi * Math.Pow(R, 3)) / 3; }
    }
}
