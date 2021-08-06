using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using den_office.Models;


namespace den_office.Tests
{
    public class Game : IGameData
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Game> GetAll()
        {
            return GetAll();
        }
    }
}
