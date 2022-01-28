using Care4Pets.Api.Dal.Repositories;
using Care4Pets.Api.Repositories;
using Care4Pets.Api.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Bll
{
    public class AdministrationWayBLL
    {
        private IAdministrationWayRepository _repository;

        public AdministrationWayBLL()
        {
            _repository = new AdministrationWayRepository(new Care4PetsDbContext());
        }

        public AdministrationWayBLL(IAdministrationWayRepository repository)
        {
            _repository = repository;
            _repository.DeleteAdministrationWay(new Guid());
        }
    }
}
