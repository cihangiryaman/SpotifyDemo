using SpotifyDemo.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.DAL.Entities
{
	public class ContentCreator : IEntity<ContentCreator>
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string About { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string ImagePath { get; set; }
		public DateTime JoinDate { get; set; }
	}
}
