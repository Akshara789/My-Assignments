using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
            
                number.Add(1);
                number.Add(6);
            
            Console.WriteLine(number);
        }
    }
}
