using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addfunction
{
    internal class Program
    {
        static int add(int a,int b)
        {
            int sum;
            sum=a+ b;
            return sum;
        }
        static void Main(string[] args)
        {
            int a = 5, b = 6;
            int sum = add(a, b);
            Console.WriteLine("SUM OF TWO NUMBERS IS,{0}", sum);
        }
    }
}
