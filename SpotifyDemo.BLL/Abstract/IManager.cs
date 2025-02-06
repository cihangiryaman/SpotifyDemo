using SpotifyDemo.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.BLL.Abstract
{
	public interface IManager<T> where T : class, IEntity<T>, new()
	{

	}
}
