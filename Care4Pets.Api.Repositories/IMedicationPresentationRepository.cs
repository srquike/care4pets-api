using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    public interface IMedicationPresentationRepository
    {
        Task<IEnumerable<MedicationPresentation>> GetMedicationPresentations();
        Task<MedicationPresentation> GetMedicationPresentationById(Guid id);
        Task<int> InsertMedicationPresentation(MedicationPresentation medicationPresentation);
        Task<int> DeleteMedicationPresentation(Guid id);
        Task<int> UpdateMedicationPresentation(MedicationPresentation medicationPresentation);
        Task<int> Save();
    }
}
