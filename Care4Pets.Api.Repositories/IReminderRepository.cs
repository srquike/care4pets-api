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
        IEnumerable<Reminder> GetReminders();
        Reminder GetReminderById(Guid id);
        void InsertReminder(Reminder reminder);
        void DeleteReminder(Guid id);
        void UpdateReminder(Reminder reminder);
        void Save();
    }
}
