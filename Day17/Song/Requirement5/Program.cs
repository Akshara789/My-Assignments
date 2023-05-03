using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> ls = new List<Song>();
            Console.WriteLine("enter number of songs");
            int n=int.Parse(Console.ReadLine());
            for(int i=0; i<n;i++)
            {
                string[] s = Console.ReadLine().Split(',');
                
                  
                DateTime dt =  DateTime.Parse(s[5]);
               
                Song s1= new Song(s[0], s[1], s[2], double.Parse(s[3]), int.Parse(s[4]),dt);
                ls.Add(s1);

                

            }
            SortedDictionary<string,int>sd= new SortedDictionary<string,int>(); 
            sd=Song.CalculateTypeCount(ls);
            Console.WriteLine("{0}{1,15}", "Song-type", "count");

            foreach(var item in sd)
            {
                Console.WriteLine("{0}{1,15}",item.Key,item.Value);    
            }
        }
    }
}
