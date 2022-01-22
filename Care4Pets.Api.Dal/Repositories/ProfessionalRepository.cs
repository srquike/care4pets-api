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
    public class ProfessionalRepository : IProfessionalRepository, IDisposable
    {
        private Care4PetsDbContext _context;
        private bool _disposed;

        public ProfessionalRepository(Care4PetsDbContext context)
        {
            _context = context;
            _disposed = false;
        }

        public async Task<int> DeleteProfessional(Guid id)
        {
            Professional professional = await _context.Professionals.FindAsync(id);
            _context.Professionals.Remove(professional);
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

        public async Task<Professional> GetProfessionalById(Guid id)
        {
            return await _context.Professionals.FindAsync(id);
        }

        public async Task<IEnumerable<Professional>> GetProfessionals()
        {
            return await _context.Professionals.ToListAsync();
        }

        public async Task<int> InsertProfessional(Professional professional)
        {
            _context.Professionals.Add(professional);
            return await Save();
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateProfessional(Professional professional)
        {
            _context.Entry(professional).State = EntityState.Modified;
            return await Save();
        }
    }
}