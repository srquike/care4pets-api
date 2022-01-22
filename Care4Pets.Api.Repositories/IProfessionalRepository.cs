using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    public interface IProfessionalRepository
    {
        Task<IEnumerable<Professional>> GetProfessionals();
        Task<Professional> GetProfessionalById(Guid id);
        Task<int> InsertProfessional(Professional professional);
        Task<int> DeleteProfessional(Guid id);
        Task<int> UpdateProfessional(Professional professional);
        Task<int> Save();
    }
}
