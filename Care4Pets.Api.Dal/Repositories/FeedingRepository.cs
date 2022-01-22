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
    public class FeedingRepository : IFeedingRepository, IDisposable
    {
        private Care4PetsDbContext _context;
        private bool _disposed;

        public FeedingRepository(Care4PetsDbContext context)
        {
            _context = context;
            _disposed = false;
        }

        public async Task<int> DeleteFeeding(Guid id)
        {
            Feeding feeding = await _context.Feedings.FindAsync(id);
            _context.Feedings.Remove(feeding);
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

        public async Task<Feeding> GetFeedingById(Guid id)
        {
            return await _context.Feedings.FindAsync(id);
        }

        public async Task<IEnumerable<Feeding>> GetFeedings()
        {
            return await _context.Feedings.ToListAsync();
        }

        public async Task<int> InsertFeeding(Feeding feeding)
        {
            _context.Feedings.Add(feeding);
            return await Save();
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateFeeding(Feeding feeding)
        {
            _context.Entry(feeding).State = EntityState.Modified;
            return await Save();
        }
    }
}