using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    interface IReminderTypeRepository
    {
        IEnumerable<ReminderType> GetReminderTypes();
        ReminderType GetReminderTypeById(int id);
        void InsertReminderType(ReminderType reminderType);
        void DeleteReminderType(int id);
        void UpdateReminderType(ReminderType reminderType);
        void Save();
    }
}
