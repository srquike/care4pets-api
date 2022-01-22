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
    public class RepeatTypeRepository : IRepeatTypeRepository, IDisposable
    {
        private Care4PetsDbContext _dbContext;
        private bool _isDisposed;

        public RepeatTypeRepository(Care4PetsDbContext dbContext)
        {
            _dbContext = dbContext;
            _isDisposed = false;
        }

        public async Task<int> DeleteRepeatType(int id)
        {
            RepeatType repeatType = await _dbContext.RepeatTypes.FindAsync(id);
            _dbContext.RepeatTypes.Remove(repeatType);
            return await Save();
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

        public async Task<RepeatType> GetRepeatTypeById(int id)
        {
            return await _dbContext.RepeatTypes.FindAsync(id);
        }

        public async Task<IEnumerable<RepeatType>> GetRepeatTypes()
        {
            return await _dbContext.RepeatTypes.ToListAsync(); 
        }

        public async Task<int> InsertRepeatType(RepeatType repeatType)
        {
            _dbContext.RepeatTypes.Add(repeatType);
            return await Save();
        }

        public async Task<int> Save()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> UpdateRepeatType(RepeatType repeatType)
        {
            _dbContext.Entry(repeatType).State = EntityState.Modified;
            return await Save();
        }
    }
}