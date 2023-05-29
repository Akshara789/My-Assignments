using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Req4
{
    
    
        class PopularityComparer : IComparer<Song>
        {

            public int Compare(Song x, Song y)
            {
                return x.NumberOfDownloads.CompareTo(y.NumberOfDownloads);
            }
        }
    }

