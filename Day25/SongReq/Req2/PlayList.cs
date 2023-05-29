using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Req2
{
    public  class PlayList
    {
        private string _name;
        private List<Song> _songlist;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<Song> Songlist
        {
            get { return _songlist; }
            set { _songlist = value; }
        }
        public PlayList()
        {

        }
        public PlayList(string _name, List<Song> _songlist)
        {
           Name= _name; 
            Songlist= _songlist;    
        }   
       public void AddSongToPlaylist(Song song)
        {
            _songlist.Add(song);    
        }
        public bool RemoveSongFromPlaylist(String name)
        {
            foreach (Song s in _songlist)
            {
                if (s.Name == name)
                {
                    return Songlist.Remove(s);

                }
            }
                return false;
            
        }
        public void DisplaySongs()
        {
            if(_songlist.Count==0)
            {
                Console.WriteLine("No song to show");
            }
            Console.WriteLine("songs in " + Name);
            Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}",
               "Name", "Artist", "Song Type", "Rating", "No of Download", "Date Downloaded");
            foreach (Song s in Songlist)
                Console.WriteLine(s);
        }
    }
}
