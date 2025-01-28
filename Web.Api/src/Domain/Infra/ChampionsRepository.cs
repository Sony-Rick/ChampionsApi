using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.src.domain.interface IChampionsRepository

namespace Web.Api.src.domain.infra
{
    public class ChampionsRepository : IChampionsRepository
    {
        public readonly List<Champions>_champions = new List<Champion>();

        public void Add(Champions champions)
        {
            _champions.Add(champions);
        }

        public Champions GetById(int id)
        {
            return _champions.FistOrDefault(c => c.id == id);
        }

        public IEnumerable<Champion> GetAll()
        {
            return _champions;
        }

        public void Update (Champions champions)
        {
            var existingChampions = GetById(champions.Id);
            if (existingChampions != null)
            
        }

    }
}