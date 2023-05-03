using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrlist_contains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr=new ArrayList();
            {
               arr.Add(1);
                arr.Add(2);
                arr.Add("akshara");

            };
            Console.WriteLine(arr.Contains(1));
            Console.WriteLine(arr.Contains("akshara")); 
        }
    }
}
