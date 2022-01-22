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
    public class NotificationTypeRepository : INotificationTypeRepository, IDisposable
    {
        private Care4PetsDbContext _context;
        private bool _disposed;

        public NotificationTypeRepository(Care4PetsDbContext context)
        {
            _context = context;
            _disposed = false;
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

        public async Task<NotificationType> GetNotificationTypeById(int id)
        {
            return await _context.NotificationTypes.FindAsync(id);
        }

        public async Task<IEnumerable<NotificationType>> GetNotificationTypes()
        {
            return await _context.NotificationTypes.ToListAsync();
        }
    }
}