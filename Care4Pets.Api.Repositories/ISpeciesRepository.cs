using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    public interface ISpeciesRepository
    {
        IEnumerable<Species> GetSpecies();
        Species GetSpeciesById();
        void InsertSpecie(Species species);
        void Save();
    }
}
