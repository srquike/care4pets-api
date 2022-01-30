using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Bol.DTOs
{
    public class MedicationDTO
    {
        public string Name { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Manufacturer { get; set; }
        public DateTime? ManufacturingDate { get; set; }
        public string BatchNumber { get; set; }
        public float UnitPrice { get; set; }
        public float SalePrice { get; set; }        
    }

    public class RawMedicationDTO : MedicationDTO
    {
        public Guid Id { get; set; }
        public Guid? AdministrationWayId { get; set; }
        public Guid? MedicationPresentationId { get; set; }
    }

    public class CustomMedicationDTO : MedicationDTO
    {
        public string AdministrationWay { get; set; }
        public string Presentation { get; set; }
    }
}
