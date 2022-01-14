using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Dal
{
    class Care4PetsDbContext : DbContext
    {
        public Care4PetsDbContext() : base("name=Care4PetsDbConnectionString")
        {

        }
    }
}
