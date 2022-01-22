using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    public interface IPrescriptionRepository
    {
        Task<IEnumerable<Prescription>> GetPrescriptions();
        Task<Prescription> GetPrescriptionById(Guid id);
        Task<int> InsertPrescription(Prescription prescription);
        Task<int> DeletePrescription(Guid id);
        Task<int> UpdatePrescription(Prescription prescription);
        Task<int> Save();
    }
}