using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChampionsApiinterface
{
    
}
{
    public interface ChampionsRepository
    {
        void Add(Champions champions); 
        Champions GetById(int id);
        IEnumerable<Champions> GetAll();

        void Update(Champions champions);
        void  Delete(int id);
    }
}