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
        IEnumerable<Professional> GetProfessionals();
        Profession GetProfessionById(Guid id);
        void InsertProfessional(Professional professional);
        void DeleteProfessional(Guid id);
        void UpdateProfessional(Professional professional);
        void Save();
    }
}
