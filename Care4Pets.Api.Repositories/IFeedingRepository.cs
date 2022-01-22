using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    public interface IFeedingRepository
    {
        Task<IEnumerable<Feeding>> GetFeedings();
        Task<Feeding> GetFeedingById(Guid id);
        Task<int> InsertFeeding(Feeding feeding);
        Task<int> DeleteFeeding(Guid id);
        Task<int> UpdateFeeding(Feeding feeding);
        Task<int> Save();
    }
}
