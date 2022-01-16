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
        IEnumerable<Prescription> GetPrescriptions();
        Prescription GetPrescriptionById(Guid id);
        void InsertPrescription(Prescription prescription);
        void DeletePrescription(Guid id);
        void UpdatePrescription(Prescription prescription);
        void Save();
    }
}
