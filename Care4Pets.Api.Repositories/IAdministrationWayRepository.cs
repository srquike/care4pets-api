using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    public interface IAdministrationWayRepository
    {
        Task<IEnumerable<AdministrationWay>> GetAdministrationWays();
        Task<AdministrationWay> GetAdministrationWayById(Guid id);
        Task<int> InsertAdministrationWay(AdministrationWay administrationWay);
        Task<int> DeleteAdministrationWay(Guid id);
        Task<int> UpdateAdministrationWay(AdministrationWay administrationWay);
        Task<int> Save();
    }
}
