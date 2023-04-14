using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "1001,ammu@gmail.com";
            String[] entries = input.Split(',');
            foreach (string entry in entries) 
            {
                Console.WriteLine(entry);
            }
        }
    }
}
