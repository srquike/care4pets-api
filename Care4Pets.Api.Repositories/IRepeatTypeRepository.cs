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
        IEnumerable<RepeatType> GetRepeatTypes();
        RepeatType GetRepeatTypeById(int id);
        void InsertRepeatType(RepeatType repeatType);
        void DeleteRepeatType(int id);
        void UpdateRepeatType(RepeatType repeatType);
        void Save();
    }
}
