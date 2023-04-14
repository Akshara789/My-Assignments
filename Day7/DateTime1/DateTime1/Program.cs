using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            Console.WriteLine(dt);
            DateTime dt1= new DateTime(2023,04,11);
            Console.WriteLine(dt1);
            TimeSpan ts = new TimeSpan(25,20,55);
            DateTime newDate = dt1.Add(ts);
            Console.WriteLine(newDate);
            Console.WriteLine(dt == dt1);   
            
        }
    }
}
