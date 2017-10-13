using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Assignment2.Models;

namespace Assignment2.Controllers
{
    public class SongsController : ApiController
    {
        // GET: api/Songs
        public IEnumerable<Song> Get()
        {
            return SongList.GetAll();
        }

        // GET: api/Songs/5
        public Song Get(int songId)
        {
            return SongList.GetSong(songId);
        }

        // POST: api/Songs
        public Song Post(Song value)
        {
            SongList.CreateSong(value);
            return value;
        }

        // PUT: api/Songs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Songs/5
        public void Delete(int id)
        {
        }
    }
}
