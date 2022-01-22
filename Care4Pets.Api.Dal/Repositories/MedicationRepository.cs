using Care4Pets.Api.Bol;
using Care4Pets.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Dal.Repositories
{
    public class MedicationRepository : IMedicationRepository, IDisposable
    {
        private Care4PetsDbContext _context;
        private bool _disposed;

        public MedicationRepository(Care4PetsDbContext context)
        {
            _context = context;
            _disposed = false;
        }

        public async Task<int> DeleteMedication(Guid id)
        {
            Medication medication = await _context.Medications.FindAsync(id);
            _context.Medications.Remove(medication);
            return await Save();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<Medication> GetMedicationById(Guid id)
        {
            return await _context.Medications.FindAsync(id);
        }

        public async Task<IEnumerable<Medication>> GetMedications()
        {
            return await _context.Medications.ToListAsync();
        }

        public async Task<int> InsertMedication(Medication medication)
        {
            _context.Medications.Add(medication);
            return await Save();
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateMedication(Medication medication)
        {
            _context.Entry(medication).State = EntityState.Modified;
            return await Save();
        }
    }
}