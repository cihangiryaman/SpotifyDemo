using Microsoft.EntityFrameworkCore;
using SpotifyDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.DAL.Contexts
{
    public class SpotifyDemoContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Sound> Sounds { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<SoundType> SoundTypes { get; set; }
        public DbSet<PlaylistSound> PlaylistSounds { get; set; }
        public DbSet<AlbumSound> AlbumSounds { get; set; }
        public DbSet<Podcast> Podcasts { get; set; }
        public DbSet<PodcastSound> PodcastSounds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Filename=Database.db");
        }
    }
}
