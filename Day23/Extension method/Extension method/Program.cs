﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_method
{
    public static class Program
    {
        public static void Main()
        {
            int i = 10;
            bool result = i.IsGreaterThan(100);
            Console.WriteLine(result);
        }
    }
    
      
    
        public static class IntExtensions
        {
            public static bool IsGreaterThan(this int i, int value)
            {
                return i > value;
            }
        }
    
}

