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
    public class ReminderRepository : IReminderRepository, IDisposable
    {
        private Care4PetsDbContext _context;
        private bool _disposed;

        public ReminderRepository(Care4PetsDbContext context)
        {
            _context = context;
            _disposed = false;
        }        

        public async Task<int> DeleteReminder(Guid id)
        {
            Reminder reminder = await _context.Reminders.FindAsync(id);
            _context.Reminders.Remove(reminder);
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

        public async Task<Reminder> GetReminderById(Guid id)
        {
            return await _context.Reminders.FindAsync(id);
        }

        public async Task<IEnumerable<Reminder>> GetReminders()
        {
            return await _context.Reminders.ToListAsync();
        }

        public async Task<int> InsertReminder(Reminder reminder)
        {
            _context.Reminders.Add(reminder);
            return await Save();
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateReminder(Reminder reminder)
        {
            _context.Entry(reminder).State = EntityState.Modified;
            return await Save();
        }
    }
}