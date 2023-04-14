using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = 0.0, Area;
            Console.WriteLine("Enter radius");
            radius = double.Parse(Console.ReadLine());
            Area = AreaC(radius);
            Console.WriteLine(Area);
        }
        static double AreaC(double radius)
        {
            double Area;
            Area = 3.14 * radius * radius;
            return Area;
        } 

        }
    }

