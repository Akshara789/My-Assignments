using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n=int.Parse(Console.ReadLine());
            bool check = isPowerOfTwo(n);

            if(check)
            {
                Console.WriteLine(n+ " is  a power of 2");
            }
            else
            {
                Console.WriteLine(n+ "is not a power of 2");
               
            }
        }
        public static bool isPowerOfTwo(int n)
        {
            while((n%2==0)&& n>1)
            {
                n = n / 2;
            }
            return (n==1);    
        }
    }
}
