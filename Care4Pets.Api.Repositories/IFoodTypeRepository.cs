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
        Task<IEnumerable<FoodType>> GetFoodTypes();
        Task<FoodType> GetFoodTypeById(int id);
        Task<int> InsertFoodType(FoodType foodType);
        Task<int> DeleteFoodTyoe(int id);
        Task<int> UpdateFoodType(FoodType foodType);
        Task<int> Save();
    }
}
