using Care4Pets.Api.Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Text;
using Care4Pets.Api.Bol;

namespace Care4Pets.Api.Controllers
{
    public class EventsController : ApiController
    {
        private readonly EventBLL _eventBLL;

        public EventsController()
        {
            _eventBLL = new EventBLL();
        }

        [HttpPost]
        [Route("api/v1/events")]
        public async Task<IHttpActionResult> AddNewEvent([FromBody] Event @event)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _eventBLL.CreateEvent(@event))
            {
                return Ok();
            }

            return BadRequest(ModelState);
        }

        [HttpGet]
        [Route("api/v1/events")]
        public async Task<IHttpActionResult> GetAllEvents()
        {
            var events = await _eventBLL.GetEventsAsync();

            if (events != null)
            {
                return Ok(events);
            }

            return NotFound();
        } 
    }
}
