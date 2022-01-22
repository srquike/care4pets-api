using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    public interface IEventTypeRepository
    {
        Task<IEnumerable<EventType>> GetEventTypes();
        Task<EventType> GetEventTypeById(int id);
        Task<int> InsertEventType(EventType eventType);
        Task<int> DeleteEventType(int id);
        Task<int> UpdateEventType(EventType eventType);
        Task<int> Save();
    }
}
