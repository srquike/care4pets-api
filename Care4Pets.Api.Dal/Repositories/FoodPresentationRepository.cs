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
    public class FoodPresentationRepository : IFoodPresentationRepository, IDisposable
    {
        private Care4PetsDbContext _context;
        private bool _disposed;

        public FoodPresentationRepository(Care4PetsDbContext context)
        {
            _context = context;
            _disposed = false;
        }

        public async Task<int> DeleteFoodPresentation(int id)
        {
            FoodPresentation foodPresentation = await _context.FoodPresentations.FindAsync(id);
            _context.FoodPresentations.Remove(foodPresentation);
            return await Save();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<FoodPresentation> GetFoodPresentationById(int id)
        {
            return await _context.FoodPresentations.FindAsync(id);
        }

        public async Task<IEnumerable<FoodPresentation>> GetFoodPresentations()
        {
            return await _context.FoodPresentations.ToListAsync();
        }

        public async Task<int> InsertFoodPresentation(FoodPresentation foodPresentation)
        {
            _context.FoodPresentations.Add(foodPresentation);
            return await Save();
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateFoodPresentation(FoodPresentation foodPresentation)
        {
            _context.Entry(foodPresentation).State = EntityState.Modified;
            return await Save();
        }
    }
}