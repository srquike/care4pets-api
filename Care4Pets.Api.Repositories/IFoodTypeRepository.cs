using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    public interface IFoodTypeRepository
    {
        IEnumerable<FoodType> GetFoodTypes();
        FoodType GetFoodTypeById(int id);
        void InsertFoodType(FoodType foodType);
        void DeleteFoodTyoe(int id);
        void UpdateFoodType(FoodType foodType);
        void Save();
    }
}
