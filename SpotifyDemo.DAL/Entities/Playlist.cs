using SpotifyDemo.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.DAL.Entities
{
    public class Playlist: IEntity<Playlist> //tüm çalma listesi
    {
        public int Id { get; set; }
        public int FK_UserId { get; set; }
        public int Name { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public bool IsPublic { get; set; }
    }
}
