using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    internal class Program
    {

        static string armstrongNumber(int n)
        {
            int temp = 0, a = 0;
            int b = n;
            while (n > 0)
            {
                temp = n % 10;
                a = (int)(a + Math.Pow(temp, 3));
                n = n / 10;
            }
                if (b == a)
                {
                    return "yes";
                }
                else
                {
                    return "no";
                }

            
        }
            static void Main(string[] args)
            {
                Console.WriteLine("ENTER NUMBER");
               int  n = int.Parse(Console.ReadLine());
                string result;
                result = armstrongNumber(n);
                Console.WriteLine(result);




            }
        
    }
}

