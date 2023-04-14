using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("enter number of rows");
            int rows=int.Parse(Console.ReadLine());
            for(i=1;i<=rows;i++) 
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
