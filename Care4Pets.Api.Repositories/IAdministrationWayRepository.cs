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
        IEnumerable<AdministrationWay> GetAdministrationWays();
        AdministrationWay GetAdministrationWayById(Guid id);
        void InsertAdministrationWay(AdministrationWay administrationWay);
        void DeleteAdministrationWay(Guid id);
        void UpdateAdministrationWay(AdministrationWay administrationWay);
        void Save();
    }
}
