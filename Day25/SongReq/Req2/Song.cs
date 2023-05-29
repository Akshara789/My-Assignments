using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Req2
{
    public class Song
    {
        private string _name;
        private string _artist;
        private string _SongType;
        private double _rating;
        private int _numberOfDownloads;
        private DateTime _dateDownloaded;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }
        public string SongType
        {
            get { return _SongType; }
            set
            {
                _SongType = value;
            }


        }
        public double Rating
        {
            get { return _rating; }
            set
            {
                _rating = value;
            }
        }
        public int NumberOfDownloads
        {
            get { return _numberOfDownloads; }
            set
            {
                _numberOfDownloads = value;
            }
        }
        public DateTime DateDownloaded
        {
            get { return _dateDownloaded; }
            set
            {
                _dateDownloaded = value;
            }
        }
        public Song()
        {

        }
        public Song(string _name, string _artist, string _songType, double _rating, int _numberOfDownloads, DateTime _dateDownloaded)

        {
            Name = _name;
            Artist = _artist;
            SongType = _songType;
            Rating = _rating;
            NumberOfDownloads = _numberOfDownloads;
            DateDownloaded = _dateDownloaded;

        }
        public override string ToString()
        {
            return "Name:" + Name + "\nArtist:" + Artist + "\nSong Type:" + SongType + "\nRating:" + Rating + "Number of Downloads:" + NumberOfDownloads + "\nDate Downloaded:" + DateDownloaded.ToString("dd-mm-yyyy");
        }
        public override bool Equals(object obj)
        {
            Song s = obj as Song;
            return Name.Equals(s.Name) && Artist.Equals(s.Artist) && SongType.Equals(s.SongType);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Artist.GetHashCode() ^ SongType.GetHashCode();
        }
        public static Song CreateSong(string song)
        {
            string[] songdetails = Console.ReadLine().Split(',');
            DateTime dt = DateTime.Parse(Console.ReadLine());
            return new Song(songdetails[0], songdetails[1],songdetails[2], double.Parse(songdetails[3]), int.Parse(songdetails[4]), dt);
        }
    }
}

    

