using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Care4Pets.Api.Bol
{
    public class MedicationModel
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
    }
}