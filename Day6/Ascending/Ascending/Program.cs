using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascending
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter two numbers:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            if (n1 < n2)
            {
                Console.WriteLine("The number in ascending order are:");
                Console.WriteLine(n1);
                Console.WriteLine(n2);
            }
            else
            {
                Console.WriteLine("The number in ascending order are:");
                Console.WriteLine(n2);
                Console.WriteLine(n1);
            }




        }
    }
}
