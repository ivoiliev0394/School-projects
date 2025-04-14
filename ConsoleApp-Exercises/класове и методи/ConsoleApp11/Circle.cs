using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    static class Circle
    {
        static private double pi = 3.14;
        static public double Face(double R)
        { return pi * R * R; }
        static public double Perimeter(double R)
        { return 2 * pi * R; }
    }
}
