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
    class PrescriptionRepository : IPrescriptionRepository, IDisposable
    {
        private Care4PetsDbContext _context;
        private bool _disposed;

        public PrescriptionRepository(Care4PetsDbContext context)
        {
            _context = context;
            _disposed = false;
        }

        public async Task<int> DeletePrescription(Guid id)
        {
            Prescription prescription = await _context.Prescriptions.FindAsync(id);
            _context.Prescriptions.Remove(prescription);
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

        public async Task<Prescription> GetPrescriptionById(Guid id)
        {
            return await _context.Prescriptions.FindAsync(id);
        }

        public async Task<IEnumerable<Prescription>> GetPrescriptions()
        {
            return await _context.Prescriptions.ToListAsync();
        }

        public async Task<int> InsertPrescription(Prescription prescription)
        {
            _context.Prescriptions.Add(prescription);
            return await Save();
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdatePrescription(Prescription prescription)
        {
            _context.Entry(prescription).State = EntityState.Modified;
            return await Save();
        }
    }
}