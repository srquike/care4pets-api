using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Care4Pets.Api.Bol
{
    public class Medication
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Presentation { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Manufacturer { get; set; }
        public DateTime? ManufacturingDate { get; set; }
        public string BatchNumber { get; set; }
        public float UnitPrice { get; set; } = 0.0F;
        public float SalePrice { get; set; } = 0.0F;

        public Guid? AdministrationWayId { get; set; }
        public AdministrationWay AdministrationWay { get; set; }

        public Guid? MedicationPresentationId { get; set; }
        public MedicationPresentation MedicationPresentation { get; set; }

        public ICollection<Prescription> Prescriptions { get; set; }
    }
}