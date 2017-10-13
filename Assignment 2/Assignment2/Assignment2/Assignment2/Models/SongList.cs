using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class SongList
    {
        private static List<Song> Songs = new List<Song>()
        {
            new Song
            {
                SongId = 1,
                SongName = "Gyalchester",
                SongDescription = "Amazing"

            }
        };


        public static void CreateSong(Song newSong)
        {
            Songs.Add(newSong);
        }

        public static List<Song> GetAll()
        {
            return Songs;
        }

        public static Song GetSong(int songId)
        {
            return Songs.Find(x => x.SongId == songId);
        }

        public static void UpdateSong(int songId, Song UpdatedSong)
        {
            Songs.Remove(Songs.Find(x => x.SongId == songId));
            Songs.Add(UpdatedSong);
        }

        public static void DeleteSong(int songId)
        {
            Songs.Remove(Songs.Find(x => x.SongId == songId));
        }

    }
}