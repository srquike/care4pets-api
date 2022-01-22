using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    public interface IFoodRepository
    {
        Task<IEnumerable<Food>> GetFoods();
        Task<Food> GetFoodById(Guid id);
        Task<int> InsertFood(Food food);
        Task<int> DeleteFood(Guid id);
        Task<int> UpdateFood(Food food);
        Task<int> Save();
    }
}
