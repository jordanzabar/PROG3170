using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class Song
    {
        private int songId;
        private string songName;
        private string songDescription;

        public Song()
        {


        }

        public Song(int SongId, string SongName, string SongDescription)
        {
            this.songId = SongId;
            this.songName = SongName;
            this.songDescription = SongDescription;
        }


        public int SongId
        {
            get { return songId; }
            set { songId = value; }
        }

        public string SongName
        {
            get { return songName; }
            set { songName = value; }
        }

        public string SongDescription
        {
            get { return songDescription; }
            set { songDescription = value; }
        }
    }
}