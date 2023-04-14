using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperLower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, l;
            char ch;
            char[] arr;
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            l = str.Length;
            arr = str.ToCharArray(0, l);
            Console.WriteLine("After conversion the string is:");

            for (i = 0; i < l; i++)
            {
                ch = arr[i];
                if (char.IsLower(ch))
                    Console.Write(char.ToUpper(ch));
                else
                    Console.Write(char.ToLower(ch));
            }
            Console.WriteLine("\n\n");
        }
    }
}

