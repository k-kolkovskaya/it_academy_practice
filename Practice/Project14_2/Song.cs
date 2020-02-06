using System;
using System.Collections.Generic;
using System.Text;

namespace Project14_2
{
    class Song
    {
        public string SongTitle { get; set; }
        public int Duration { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public object GetSongData(Song song)
        {
            return new { Title = song.SongTitle, Minutes = song.Duration, AlbumYear = song.Year };
        }
    }
}
