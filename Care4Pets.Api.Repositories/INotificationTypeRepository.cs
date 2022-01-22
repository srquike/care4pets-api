using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    public interface INotificationTypeRepository
    {
        Task<IEnumerable<NotificationType>> GetNotificationTypes();
        Task<NotificationType> GetNotificationTypeById(int id);
    }
}
