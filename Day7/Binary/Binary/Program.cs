using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the decimal number:");
            int n=int.Parse(Console.ReadLine());
            int[]arr=new int[10];
            int i = 0;
            while(n!=0)
            {
                arr[i] =n%2;
                n = n / 2;
                i++;
            }
            for(int j=i-1;j>=0;j--)
            {
                Console.WriteLine(arr[j]); 
            }
        }
    }
}
