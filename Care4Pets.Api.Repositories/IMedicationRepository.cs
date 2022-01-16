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
        IEnumerable<Medication> GetMedications();
        Medication GetMedicationById(Guid id);
        void InsertMedication(Medication medication);
        void DeleteMedication(Guid id);
        void UpdateMedication(Medication medication);
        void Save();
    }
}
