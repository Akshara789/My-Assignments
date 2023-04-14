using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the string:");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            

            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] >= 'a') && (arr[i] <= 'z'))
                {
                    Console.Write(char.ToUpper(arr[i]));
                    
                }
                else if ((arr[i] >= 'A') && (arr[i] <= 'Z')) 
                {
                   Console.Write(char.ToLower(arr[i]));
                   
                }
                else
                {
                    break;
                }
            }
            
            
            
        }
    }
}
            

            


        
            
    
            
             
