using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Absolute_diff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, diff;
            const int x = 51;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());
            diff = diffC(n, x);
            Console.WriteLine(diff);

        }
        static int diffC(int n,int x)
        {
            int diff;
            diff = n - x;
            if(n>x)
            {
                return (n - x) * 3;
            }
            return (x - n);
        }
    }
}
