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
    public class ReminderTypeRepository : IReminderTypeRepository, IDisposable
    {
        private Care4PetsDbContext _dbContext;
        private bool _isDisposed;

        public ReminderTypeRepository(Care4PetsDbContext dbContext)
        {
            _dbContext = dbContext;
            _isDisposed = false;
        }

        public async Task<int> DeleteReminderType(int id)
        {
            ReminderType reminderType = await _dbContext.RemiderTypes.FindAsync(id);
            _dbContext.RemiderTypes.Remove(reminderType);
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

        public async Task<ReminderType> GetReminderTypeById(int id)
        {
            return await _dbContext.RemiderTypes.FindAsync(id);
        }

        public async Task<IEnumerable<ReminderType>> GetReminderTypes()
        {
            return await _dbContext.RemiderTypes.ToListAsync();
        }

        public async Task<int> InsertReminderType(ReminderType reminderType)
        {
            _dbContext.RemiderTypes.Add(reminderType);
            return await Save();
        }

        public async Task<int> Save()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> UpdateReminderType(ReminderType reminderType)
        {
            _dbContext.Entry(reminderType).State = EntityState.Modified;
            return await Save();
        }
    }
}