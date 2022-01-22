using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetEvents();
        Task<Event> GetEventById(Guid id);
        Task<int> InsertEvent(Event @event);
        Task<int> DeleteEvent(Guid id);
        Task<int> UpdateEvent(Event @event);
        Task<int> Save();
    }
}
