using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{
    internal class Program
    {

        class Telephone
        {
            protected string phonetype;
            public void Ring()
            {
                Console.WriteLine("Ringing the" + phonetype + ".");
            }
        }
        class Electronicphone : Telephone
        {
            public string phonetypes = "Digital";

            public Electronicphone()
            {
                phonetype = "Digital";
            }

            public void Run()
            {
                base.Ring();
            }
        }

        static void Main(string[] args)
        {
            Electronicphone tel = new Electronicphone();
            tel.Run();
        }
    }
}
