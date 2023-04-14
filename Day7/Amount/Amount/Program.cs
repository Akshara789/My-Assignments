using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter amount");
            int amt=int.Parse(Console.ReadLine());
            int[] arr = { 2000,500,200,100,50,20,10,5,2,1 };
            
            for(int i=0;i<=10;i++) 
            {

               int a = amt/arr[i];
                amt = amt % arr[i];
                Console.WriteLine(a);
                   
                
            }
        }
    }
}
