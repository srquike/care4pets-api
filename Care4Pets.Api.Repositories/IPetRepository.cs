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
        Task<IEnumerable<Pet>> GetPets();
        Task<Pet> GetPetById(Guid id);
        Task<int> InsertPet(Pet pet);
        Task<int> DeletePet(Guid id);
        Task<int> UpdatePet(Pet pet);
        Task<int> Save();
    }
}
