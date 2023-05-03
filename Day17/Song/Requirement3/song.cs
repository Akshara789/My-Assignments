﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement3
{
    public  class song
    {
        private string _name;
        private string _artist;
        private string _songType;  
        private double _rating;
       private int _numberOfDownloads;
        private DateTime _dateDownloaded;

        public string Name
        {
            get { return _name; }
            set { _name = value; }  
        }
        public string Artist
        { get { return _artist; }
            set {_artist = value; } 
        }
        public string SongType
        {
            get { return _songType; }
            set
            {
                _songType = value;
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
            set {  _numberOfDownloads = value; } 
        }
        public DateTime DateDownloaded
        { get { return _dateDownloaded; }
            set
            {
                _dateDownloaded = value;
            }
        }

        public song()
        {

        }

        public song(string name,string artist,string songType,double rating,int numberOfDownloads,DateTime dateDownloaded)
        {
            _name = name;   
            _artist = artist;   
            _songType = songType;   
            _rating = rating;   
            _numberOfDownloads = numberOfDownloads; 
            _dateDownloaded = dateDownloaded;   

        }

        public override string ToString()
        {
            return string.Format($"Name:{_name}\n,Artist:{_artist}\n,songType:{_songType}\n,Rating:{_rating}\n,NumberOfDownloads:{_numberOfDownloads}\n,DateDownloaded:{_dateDownloaded}") ;
        }

    }
}
