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
    public class EventRepository : IEventRepository, IDisposable
    {
        private Care4PetsDbContext _context;
        private bool _disposed = false;

        public EventRepository(Care4PetsDbContext context)
        {
            _context = context;
        }

        public async Task<int> DeleteEvent(Guid id)
        {
            Event @event = await _context.Events.FindAsync(id);
            _context.Events.Remove(@event);
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

        public async Task<Event> GetEventById(Guid id)
        {
            return await _context.Events.FindAsync(id);
        }

        public async Task<IEnumerable<Event>> GetEvents()
        {
            return await _context.Events.ToListAsync();
        }

        public async Task<int> InsertEvent(Event @event)
        {
            _context.Events.Add(@event);
            return await Save();
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateEvent(Event @event)
        {
            _context.Entry(@event).State = EntityState.Modified;
            return await Save();
        }
    }
}
