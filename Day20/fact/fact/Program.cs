using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact
{
    internal class Program
    {
        static int fact(int a)
        {
            int result=1;
           while(a!=0)
            {
                result=result*a;
                a = a - 1; ;
                
               
            }

            return result;
        }
        static void Main(string[] args)
        {
            int a = 5;
            int result=fact(a); 
            Console.WriteLine(result);

        }
    }
}
