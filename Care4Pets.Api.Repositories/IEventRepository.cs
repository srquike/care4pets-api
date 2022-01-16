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
        IEnumerable<Event> GetEvents();
        Event GetEventById(Guid id);
        void InsertEvent(Event @event);
        void DeleteEvent(Guid id);
        void UpdateEvent(Event @event);
        void Save();
    }
}
