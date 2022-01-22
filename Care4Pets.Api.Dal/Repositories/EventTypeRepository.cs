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
    public class EventTypeRepository : IEventTypeRepository, IDisposable
    {
        private Care4PetsDbContext _context;
        private bool _disposed;

        public EventTypeRepository(Care4PetsDbContext context)
        {
            _context = context;
            _disposed = false;
        }

        public async Task<int> DeleteEventType(int id)
        {
            EventType eventType = await _context.EventTypes.FindAsync(id);
            _context.EventTypes.Remove(eventType);
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

        public async Task<EventType> GetEventTypeById(int id)
        {
            return await _context.EventTypes.FindAsync(id);
        }

        public async Task<IEnumerable<EventType>> GetEventTypes()
        {
            return await _context.EventTypes.ToListAsync();
        }

        public async Task<int> InsertEventType(EventType eventType)
        {
            _context.EventTypes.Add(eventType);
            return await Save();
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateEventType(EventType eventType)
        {
            _context.Entry(eventType).State = EntityState.Modified;
            return await Save();
        }
    }
}