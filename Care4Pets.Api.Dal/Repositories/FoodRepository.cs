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
    public class FoodRepository : IFoodRepository, IDisposable
    {
        private Care4PetsDbContext _context;
        private bool _disposed;

        public FoodRepository(Care4PetsDbContext context)
        {
            _context = context;
            _disposed = false;
        }

        public async Task<int> DeleteFood(Guid id)
        {
            Food food = await _context.Foods.FindAsync(id);
            _context.Foods.Remove(food);
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

        public async Task<Food> GetFoodById(Guid id)
        {
            return await _context.Foods.FindAsync(id);
        }

        public async Task<IEnumerable<Food>> GetFoods()
        {
            return await _context.Foods.ToListAsync();
        }

        public async Task<int> InsertFood(Food food)
        {
            _context.Foods.Add(food);
            return await Save();
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateFood(Food food)
        {
            _context.Entry(food).State = EntityState.Modified;
            return await Save();
        }
    }
}