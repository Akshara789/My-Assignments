using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi
{
    internal class Program
    {
        static int mul(int a,int b)
        {
            int result;
            result = a* b;  
            return result;  
        }
        static void Main(string[] args)
        {
            int a = 8, b = 9;
            int result=mul(a,b);
            Console.WriteLine($"result of multiplication is {result}");  
        }
    }
}
