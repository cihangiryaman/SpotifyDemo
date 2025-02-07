using SpotifyDemo.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.DAL.Entities
{
    public class PlaylistSound : IEntity<PlaylistSound> //çalma listesinin içindeki bir şarkı
    {
        public int Id { get; set; }
        public int FK_PlaylistId { get; set; }
        public int FK_SoundId { get; set; }
        public DateTime AttachDate { get; set; }
    }
}
