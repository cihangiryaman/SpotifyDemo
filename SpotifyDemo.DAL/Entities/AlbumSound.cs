using SpotifyDemo.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.DAL.Entities
{
    public class AlbumSound:IEntity<AlbumSound>
    {
        public int Id { get; set; }
        public int FK_SoundId { get; set; }
        public int FK_AlbumId { get; set; }
    }
}
