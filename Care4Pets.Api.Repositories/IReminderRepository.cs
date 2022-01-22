using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    public interface IReminderRepository
    {
        Task<IEnumerable<Reminder>> GetReminders();
        Task<Reminder> GetReminderById(Guid id);
        Task<int> InsertReminder(Reminder reminder);
        Task<int> DeleteReminder(Guid id);
        Task<int> UpdateReminder(Reminder reminder);
        Task<int> Save();
    }
}
