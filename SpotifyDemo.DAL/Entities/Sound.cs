using SpotifyDemo.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.DAL.Entities
{
    public class Sound : IEntity<Sound> // her türlü ses dosyası
    {
        public int Id { get; set; }
        public int FK_TypeId { get; set; }
        public int FK_CreatorId { get; set; }
        public int Duration { get; set; }
        public int ViewCount { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SoundPath { get; set; }
        public string ImagePath { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
