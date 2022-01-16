using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    public interface IPetRepository
    {
        IEnumerable<Pet> GetPets();
        Pet GetPetById(Guid id);
        void InsertPet(Pet pet);
        void DeletePet(Guid id);
        void UpdatePet(Pet pet);
        void Save();
    }
}
