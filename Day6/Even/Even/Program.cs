using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n = 100;
            for (i = 1; i <= n; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine("The series of even numbers are:" + i);
                }
            }
        }
    }
}     
