using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.DAL.Abstract
{
    public interface IEntity<T> where T : class, new()
    {

    }
}
