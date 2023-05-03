using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    internal class Program
    {
        static int swap(int a, int b) 
        {
            swap(a, b);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int a=int.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            int b = int.Parse(Console.ReadLine());
            int result=swap(a, b);
            return result;

        }
    }
}
