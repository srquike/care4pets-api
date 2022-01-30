using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Bol
{
    public class EventType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
