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
    class FoodTypeRepository : IFoodTypeRepository, IDisposable
    {
        private Care4PetsDbContext _context;
        private bool _disposed;

        public FoodTypeRepository(Care4PetsDbContext context)
        {
            _context = context;
            _disposed = false;
        }

        public async Task<int> DeleteFoodTyoe(int id)
        {
            FoodType foodType = await _context.FoodTypes.FindAsync(id);
            _context.FoodTypes.Remove(foodType);
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

        public async Task<FoodType> GetFoodTypeById(int id)
        {
            return await _context.FoodTypes.FindAsync(id);
        }

        public async Task<IEnumerable<FoodType>> GetFoodTypes()
        {
            return await _context.FoodTypes.ToListAsync();
        }

        public async Task<int> InsertFoodType(FoodType foodType)
        {
            _context.FoodTypes.Add(foodType);
            return await Save();
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateFoodType(FoodType foodType)
        {
            _context.Entry(foodType).State = EntityState.Modified;
            return await Save();
        }
    }
}