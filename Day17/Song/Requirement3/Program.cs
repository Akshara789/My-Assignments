using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<song>ls=songRepo.GetAllSongs();
            foreach (song song in ls)
            {
                Console.WriteLine(song);     
            }

        }
    }
}
