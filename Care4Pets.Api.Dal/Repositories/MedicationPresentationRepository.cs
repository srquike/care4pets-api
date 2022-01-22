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
    public class MedicationPresentationRepository : IMedicationPresentationRepository, IDisposable
    {
        private Care4PetsDbContext _context;
        private bool _disposed;

        public MedicationPresentationRepository(Care4PetsDbContext context)
        {
            _context = context;
            _disposed = false;
        }

        public async Task<int> DeleteMedicationPresentation(Guid id)
        {
            MedicationPresentation medicationPresentation = await _context.MedicationPresentations.FindAsync(id);
            _context.MedicationPresentations.Remove(medicationPresentation);
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

        public async Task<MedicationPresentation> GetMedicationPresentationById(Guid id)
        {
            return await _context.MedicationPresentations.FindAsync(id);
        }

        public async Task<IEnumerable<MedicationPresentation>> GetMedicationPresentations()
        {
            return await _context.MedicationPresentations.ToListAsync();
        }

        public async Task<int> InsertMedicationPresentation(MedicationPresentation medicationPresentation)
        {
            _context.MedicationPresentations.Add(medicationPresentation);
            return await Save();
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateMedicationPresentation(MedicationPresentation medicationPresentation)
        {
            _context.Entry(medicationPresentation).State = EntityState.Modified;
            return await Save();
        }
    }
}