using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Bol
{
    public class MedicationPresentation
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Medication> Medications { get; set; }
    }
}
