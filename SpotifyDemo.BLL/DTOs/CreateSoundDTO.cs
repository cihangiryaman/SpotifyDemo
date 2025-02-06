using SpotifyDemo.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.BLL.DTOs
{
	public class CreateSoundDTO : IDTO
	{
		public int FK_TypeId { get; set; }
		public int FK_CreatorId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string SoundPath { get; set; }
		public string ImagePath { get; set; }
	}
}
