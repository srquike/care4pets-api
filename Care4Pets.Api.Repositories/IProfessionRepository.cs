using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    public interface IProfessionRepository
    {
        Task<IEnumerable<Profession>> GetProfessions();
        Task<Profession> GetProfessionById(Guid id);
        Task<int> InsertProfession(Profession profession);
        Task<int> DeleteProfession(Guid id);
        Task<int> UpdateProfession(Profession profession);
        Task<int> Save();
    }
}
