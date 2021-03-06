using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Bol
{
    public class Species
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
    }
}
