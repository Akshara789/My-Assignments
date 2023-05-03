using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymousadd
{
    internal class Program
    {
        public delegate int sum(int x, int y);
        static void Main(string[] args)
        {
            int result;
            sum s = delegate (int a, int b)
            {
                return a + b;
            };

            result = s(10, 20);
            Console.WriteLine(result);
        }
    }
}
