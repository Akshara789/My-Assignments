using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of the array");
            int n=int.Parse(Console.ReadLine());
            int[]arr=new int[n];

            for(int i=0;i<n;i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
                
            }
            // Prints each sequential element in array a
            for (int i=0;i< n;i++) 
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
