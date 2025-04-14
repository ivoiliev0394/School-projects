using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] points = new int[130];
              int n;
              do
              {
                  Console.Write("n=");
                  n = int.Parse(Console.ReadLine());
              } while (n <= 10 || n > 130);
              for (int i = 0; i < n; i++)
              {
                  do
                  {
                      Console.Write("points[" + i + "]=");
                      points[i] = int.Parse(Console.ReadLine());
                  } while (points[i] < 0 || points[i] > 100);
              }
              for (int i = 0; i < 10; i++)
                  for (int j = i + 1; j < n; j++)
                  {
                      if (points[j] > points[i])
                      {
                          int pom = points[j];
                          points[j] = points[i];
                          points[i] = pom;
                      }
                  }
              Console.WriteLine("Max results");
              for (int i = 0; i < 10; i++)
                  Console.WriteLine(points[i]);*/
           StreamWriter sw = new StreamWriter(@"E:\daswkalo\IT\ConsoleApp26\points.txt ");
                Random r = new Random();
                int[] points = new int[130];
                int n;
                do
                {
                    Console.Write("n=");
                    n = int.Parse(Console.ReadLine());
                    sw.WriteLine("n="+n);
                } while (n <= 10 || n > 130);
                for (int i = 0; i < n; i++)
                {
                    do
                    {
                        points[i] = r.Next(0, 101);
                        Console.WriteLine("points[{0}]={1}", i, points[i]);
                        sw.WriteLine("points[{0}]={1}", i, points[i]);
                    } while (points[i] < 0 || points[i] > 100);
                }
                for (int i = 0; i < 10; i++)
                    for (int j = i + 1; j < n; j++)
                    {
                        if (points[j] > points[i])
                        {
                            int pom = points[j];
                            points[j] = points[i];
                            points[i] = pom;
                        }
                    }
                 Console.WriteLine("Max results");
                 sw.WriteLine("Max results");
                for (int i = 0; i < 10; i++)
                { 
                Console.WriteLine(points[i]);
                sw.WriteLine(points[i]); 
                }
              sw.Close();

            
        }
        
    }
}
