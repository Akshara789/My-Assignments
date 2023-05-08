using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod2
{
    public  static class Program
    {
        static void Main(string[] args)
        {
            string s = "India is great";
            string result = s.mupper();
            Console.WriteLine(result);

        }
        
            public static string mupper(this string s)
            {
                return s.ToUpper();
            }
        }
    }

