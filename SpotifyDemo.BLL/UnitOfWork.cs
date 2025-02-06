using SpotifyDemo.BLL.Abstract;
using SpotifyDemo.DAL.Abstract;
using SpotifyDemo.DAL.Contexts;
using SpotifyDemo.DAL.Entities;
using SpotifyDemo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.BLL
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly SpotifyDemoContext _context;

		public IRepository<Album> Albums { get; }
		public IRepository<Playlist> Playlists { get; }
		public IRepository<Podcast> Podcasts { get; }
		public IRepository<User> Users { get; }

		public UnitOfWork()
		{
			_context = new SpotifyDemoContext();
			Albums = new Repository<Album>(_context);
			Playlists = new Repository<Playlist>(_context);
			Podcasts = new Repository<Podcast>(_context);
			Users = new Repository<User>(_context);
		}

		public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();

		public void Dispose() => _context.Dispose();
	}
}
