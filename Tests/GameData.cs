using den_office.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace den_office.Tests
{
    public class GameData : IGameData
    {
        public IEnumerable<Game> GetAll()
        {
            List<Game> games = new List<Game>();
            games.Add(new Game() { Name = "GTA V", Id = 0 });

            games.Add(new Game() { Name = "Battlefield 4", Id = 1 });


            games.Add(new Game() { Name = "Metin2", Id = 2 });


            return games;
        }
    }
}
