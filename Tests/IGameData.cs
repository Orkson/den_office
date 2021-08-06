using den_office.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace den_office.Tests
{
    public interface IGameData
    {
        IEnumerable<Game> GetAll();
    }
}
