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
    public class PetRepository : IPetRepository, IDisposable
    {
        private Care4PetsDbContext _context;
        private bool _disposed;

        public PetRepository(Care4PetsDbContext context)
        {
            _context = context;
            _disposed = false;
        }

        public async Task<int> DeletePet(Guid id)
        {
            Pet pet = await _context.Pets.FindAsync(id);
            _context.Pets.Remove(pet);
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

        public async Task<Pet> GetPetById(Guid id)
        {
            return await _context.Pets.FindAsync(id);
        }

        public async Task<IEnumerable<Pet>> GetPets()
        {
            return await _context.Pets.ToListAsync();
        }

        public async Task<int> InsertPet(Pet pet)
        {
            _context.Pets.Add(pet);
            return await Save();
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdatePet(Pet pet)
        {
            _context.Entry(pet).State = EntityState.Modified;
            return await Save();
        }
    }
}