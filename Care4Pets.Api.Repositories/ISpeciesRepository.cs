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
        Task<IEnumerable<Species>> GetSpecies();
        Task<Species> GetSpeciesById(int id);
        Task<int> InsertSpecie(Species species);
        Task<int> Save();
    }
}
