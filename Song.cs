using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPlay
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Album Album { get; set; }
        public string Artist { get { return Album.Artist;  } }
        public Image Image { get { return Album.Image; } }
        public string AlbumTitle { get { return Album.Title; } }
        public int Year { get { return Album.Year; } }
        public string Genre { get { return Album.Genre; } }
        public int Length { get; set; }

        public Song() { }

    }
}
