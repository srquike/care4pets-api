using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    public interface IRepeatTypeRepository
    {
        Task<IEnumerable<RepeatType>> GetRepeatTypes();
        Task<RepeatType> GetRepeatTypeById(int id);
        Task<int> InsertRepeatType(RepeatType repeatType);
        Task<int> DeleteRepeatType(int id);
        Task<int> UpdateRepeatType(RepeatType repeatType);
        Task<int> Save();
    }
}
