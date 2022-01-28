using Care4Pets.Api.Bol;
using Care4Pets.Api.Dal.Repositories;
using Care4Pets.Api.Dal;
using Care4Pets.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Bll
{
    public class EventBLL
    {
        private readonly IEventRepository _eventRepository;

        public EventBLL(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public EventBLL()
        {
            _eventRepository = new EventRepository(new Care4PetsDbContext());
        }

        public async Task<IEnumerable<Event>> GetEventsAsync()
        {
            return await _eventRepository.GetEvents();
        }

        public async Task<bool> CreateEvent(Event @event)
        {
            try
            {
                int result = await _eventRepository.InsertEvent(@event);

                if (result > 0)
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
