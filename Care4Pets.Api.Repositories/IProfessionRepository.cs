using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    public interface IProfessionRepository
    {
        IEnumerable<Profession> GetProfessions();
        Profession GetProfessionById(Guid id);
        void InsertProfession(Profession profession);
        void DeleteProfession(Guid id);
        void UpdateProfession(Profession profession);
        void Save();
    }
}
