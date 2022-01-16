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
        IEnumerable<Feeding> GetFeedings();
        Feeding GetFeedingById(Guid id);
        void InsertFeeding(Feeding feeding);
        void DeleteFeeding(Guid id);
        void UpdateFeeding(Feeding feeding);
        void Save();
    }
}
