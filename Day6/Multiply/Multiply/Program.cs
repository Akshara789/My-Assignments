using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r;
            Console.WriteLine("enter the number");
            int n=int.Parse(Console.ReadLine());
            for(int i=1;i<=10;i++) 
            {

                r= n * i;
               
                Console.WriteLine(n+"*"+i+"="+r);

            }
        }
    }
}
