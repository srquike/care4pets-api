using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Bol
{
    public class Food
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Manufacturer { get; set; }
        public DateTime? ManufacturingDate { get; set; }
        public string Brand { get; set; }
        public string BatchNumber { get; set; }
        public float UnitPrice { get; set; } = 0.0F;
        public float SalePrice { get; set; } = 0.0F;

        public int? FoodTypeId { get; set; }
        public FoodType FoodType { get; set; }

        public int? FoodPresentationId { get; set; }
        public FoodPresentation FoodPresentation { get; set; }

        public int? PetTypeId { get; set; }
        public PetType PetType { get; set; }

        public ICollection<Feeding> Feedings { get; set; }
    }
}
