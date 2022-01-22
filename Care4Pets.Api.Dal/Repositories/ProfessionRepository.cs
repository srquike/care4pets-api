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
    public class ProfessionRepository : IProfessionRepository, IDisposable
    {
        private Care4PetsDbContext _context;
        private bool _disposed;

        public ProfessionRepository(Care4PetsDbContext context)
        {
            _context = context;
            _disposed = false;
        }

        public async Task<int> DeleteProfession(Guid id)
        {
            Profession profession = await _context.Professions.FindAsync(id);
            _context.Professions.Remove(profession);
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

        public async Task<Profession> GetProfessionById(Guid id)
        {
            return await _context.Professions.FindAsync(id);
        }

        public async Task<IEnumerable<Profession>> GetProfessions()
        {
            return await _context.Professions.ToListAsync();
        }

        public async Task<int> InsertProfession(Profession profession)
        {
            _context.Professions.Add(profession);
            return await Save();
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateProfession(Profession profession)
        {
            _context.Entry(profession).State = EntityState.Modified;
            return await Save();
        }
    }
}