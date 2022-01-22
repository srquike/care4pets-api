using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    public interface IReminderTypeRepository
    {
        Task<IEnumerable<ReminderType>> GetReminderTypes();
        Task<ReminderType> GetReminderTypeById(int id);
        Task<int> InsertReminderType(ReminderType reminderType);
        Task<int> DeleteReminderType(int id);
        Task<int> UpdateReminderType(ReminderType reminderType);
        Task<int> Save();
    }
}
