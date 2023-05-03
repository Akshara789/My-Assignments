using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement3
{
    internal class songRepo
    {
        static List<song> _songs = new List<song>
        {
            new song("shape of you","Edsheeran","pop",4.8,12000,DateTime.Parse("12-04-2017")),
            new song("Perfect","Edsheeran","pop",4.5,120500,DateTime.Parse("06-08-2017")),
            new song("Mercy","ShawnMendes","Jazz",4.6,50000,DateTime.Parse("03-09-2016")),
        };

        public static List<song>GetAllSongs()
        {
            return _songs;
        }  
        
            
        
    }
}

