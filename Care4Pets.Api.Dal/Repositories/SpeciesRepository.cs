using Care4Pets.Api.Bol;
using Care4Pets.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Dal.Repositories
{
    public class SpeciesRepository : ISpeciesRepository, IDisposable
    {
        private Care4PetsDbContext _dbContext;
        private bool _isDisposed;

        public SpeciesRepository(Care4PetsDbContext dbContext)
        {
            _dbContext = dbContext;
            _isDisposed = false;
        }

        public virtual void Dispose(bool isDisposing)
        {
            if (!_isDisposed)
            {
                if (isDisposing)
                {
                    _dbContext.Dispose();
                }
            }

            _isDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<IEnumerable<Species>> GetSpecies()
        {
            return await _dbContext.Species.ToListAsync();
        }

        public async Task<Species> GetSpeciesById(int id)
        {
            return await _dbContext.Species.FindAsync(id);
        }

        public async Task<int> InsertSpecie(Species species)
        {
            _dbContext.Species.Add(species);
            return await Save();
        }

        public async Task<int> Save()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}