using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Care4Pets.Api.Bol
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool AllDay { get; set; }
        public string Notes { get; set; }

        public int? EventTypeId { get; set; }
        public EventType EventType { get; set; }

        public ICollection<Reminder> Reminders { get; set; }
    }
}
