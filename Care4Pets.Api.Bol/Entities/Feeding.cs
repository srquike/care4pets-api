using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Bol
{
    public class Feeding
    {
        public Guid Id { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
        public string Frecuency { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Guid? PetId { get; set; }
        public Pet Pet { get; set; }

        public Guid? FoodId { get; set; }
        public Food Food { get; set; }

        public ICollection<Reminder> Reminders { get; set; }
    }
}
