using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    public interface IMedicationRepository
    {
        Task<IEnumerable<Medication>> GetMedications();
        Task<Medication> GetMedicationById(Guid id);
        Task<int> InsertMedication(Medication medication);
        Task<int> DeleteMedication(Guid id);
        Task<int> UpdateMedication(Medication medication);
        Task<int> Save();
    }
}
