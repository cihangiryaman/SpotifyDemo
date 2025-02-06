using SpotifyDemo.DAL.Abstract;
using SpotifyDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.BLL.Abstract
{
	public interface IUnitOfWork : IDisposable
	{
		IRepository<Album> Albums { get; }
		IRepository<Playlist> Playlists { get; }
		IRepository<Podcast> Podcasts { get; }
		IRepository<User> Users { get; }

		Task<int> SaveChangesAsync();
	}
}
