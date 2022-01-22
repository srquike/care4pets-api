using Care4Pets.Api.Bol;
using Care4Pets.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Care4Pets.Api.Dal.Repositories
{
    public class AdministrationWayRepository : IAdministrationWayRepository, IDisposable
    {
        private Care4PetsDbContext _context;
        private bool _disposed = false;

        public AdministrationWayRepository(Care4PetsDbContext context)
        {
            _context = context;
        }

        public async Task<int> DeleteAdministrationWay(Guid id)
        {
            AdministrationWay administrationWay = await _context.AdministrationWays.FindAsync(id);
            _context.AdministrationWays.Remove(administrationWay);
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

        public async Task<AdministrationWay> GetAdministrationWayById(Guid id)
        {
            return await _context.AdministrationWays.FindAsync(id);
        }

        public async Task<IEnumerable<AdministrationWay>> GetAdministrationWays()
        {
            return await _context.AdministrationWays.ToListAsync();
        }

        public async Task<int> InsertAdministrationWay(AdministrationWay administrationWay)
        {
            _context.AdministrationWays.Add(administrationWay);
            return await Save();
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAdministrationWay(AdministrationWay administrationWay)
        {
            _context.Entry(administrationWay).State = EntityState.Modified;
            return await Save();
        }
    }
}