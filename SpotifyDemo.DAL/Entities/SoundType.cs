using SpotifyDemo.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.DAL.Entities
{
    public class SoundType : IEntity<SoundType>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
