using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPlay
{
    public class User
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public List<Playlist> Playlists { get; }

        public User() {

            Playlists = new List<Playlist>();

        }

        public void AddPlaylist(Playlist playlist) {

            Playlists.Add(playlist);

        }
    }
}
