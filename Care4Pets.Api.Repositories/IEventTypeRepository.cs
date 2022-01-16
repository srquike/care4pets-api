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
        IEnumerable<EventType> GetEventTypes();
        EventType GetEventTypeById(int id);
        void InsertEventType(EventType eventType);
        void DeleteEventType(int id);
        void UpdateEventType(EventType eventType);
        void Save();
    }
}
