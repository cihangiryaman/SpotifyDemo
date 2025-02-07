using SpotifyDemo.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.DAL.Entities
{
    public class PodcastSound : IEntity<PodcastSound> //Podcastin bir bölümü
    {
        public int Id { get; set; }
        public int FK_PodcastId { get; set; }
        public int FK_SoundId { get; set; }
        public int SeasonNumber { get; set; }
        public int EpisodeNumber { get; set; }
    }
}
