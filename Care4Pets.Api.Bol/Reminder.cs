using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Bol
{
    public class Reminder
    {
        public Guid Id { get; set; }
        public int Time { get; set; }
        public string Unit { get; set; }
        public bool Repeat { get; set; }

        public int? RepeatTypeId { get; set; }
        public RepeatType RepeatType { get; set; }

        public int? ReminderTypeId { get; set; }
        public RemiderType RemiderType { get; set; }

        public Guid? EventId { get; set; }
        public Event Event { get; set; }

        public Guid? PrescriptionId { get; set; }
        public Prescription Prescription { get; set; }


        public Guid? FeedingId { get; set; }
        public Feeding Feeding { get; set; }

        public int NotificationTypeId { get; set; }
        public NotificationType NotificationType { get; set; }


    }
}
