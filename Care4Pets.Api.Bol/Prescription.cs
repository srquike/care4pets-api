using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Bol
{
    public class Prescription
    {
        public Guid Id { get; set; }
        public string Dose { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Frecuency { get; set; }

        public Guid? PetId { get; set; }
        public Pet Pet { get; set; }

        public Guid? MedicationId { get; set; }
        public Medication Medication { get; set; }

        public Guid? ProfessionalId { get; set; }
        public Professional Professional { get; set; }

        public ICollection<Reminder> Reminders { get; set; }
    }
}
