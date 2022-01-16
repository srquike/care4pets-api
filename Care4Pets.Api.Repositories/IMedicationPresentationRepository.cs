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
        IEnumerable<MedicationPresentation> GetMedicationPresentations();
        MedicationPresentation GetMedicationPresentationById(Guid id);
        void InsertMedicationPresentation(MedicationPresentation medicationPresentation);
        void DeleteMedicationPresentation(Guid id);
        void UpdateMedicationPresentation(MedicationPresentation medicationPresentation);
        void Save();
    }
}
