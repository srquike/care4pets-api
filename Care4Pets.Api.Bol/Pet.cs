using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Care4Pets.Api.Bol
{
    public class Pet
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public string Appearance { get; set; }
        public bool Sterilized { get; set; }
        public DateTime? DateOfSterilization { get; set; }
        public string Notes { get; set; }

        public int? SpeciesId { get; private set; }
        public virtual Species Species { get; set; }

        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}