﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Req5
{
     class Program
    {
        static void Main(string[] args)
        {
            List<Song> ls = new List<Song>();
            Console.WriteLine("Enter the number of songs");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(',');
                double d = double.Parse(s[4]);
                int nd = int.Parse(s[5]);
                DateTime dt = new DateTime();
                dt = DateTime.ParseExact(s[3], "dd-MM-yyyy", null);
                Song s1 = new Song(s[0], s[1], s[2], dt, d, nd);
                ls.Add(s1);
            }
            SortedDictionary<string, int> sd = new SortedDictionary<string, int>();
            sd = Song.CalculateTypeCount(ls);
            Console.WriteLine("{0} {1,15}", "Song type", "Count");

            foreach (var item in sd)
            {
                Console.WriteLine("{0} {1,15}", item.Key, item.Value);
            }
        }
    }
}
    

