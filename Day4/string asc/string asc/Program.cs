using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_asc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            char[] arr;
            char ch;
            int i, j, l;
            Console.WriteLine("Input the string");
            str= Console.ReadLine();    
            l= str.Length;  
           arr = str.ToCharArray(0,l);
            for(i=1;i<l;i++)
                  for(j=0;j<l-i;j++)
                     if (arr[j] > arr[j+1])
                    {
                        ch = arr[j]; 
                        arr[j] = arr[j+1];
                        arr[j+1] = ch; 
                    }

            Console.WriteLine("The string in ascending order is:");
            foreach(char c in arr)
              
                {
                    ch = c;
                    Console.WriteLine(" {0} ",ch);
                }
            Console.WriteLine("\n");
           
        }
    }
}
