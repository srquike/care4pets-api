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
        IEnumerable<Food> GetFoods();
        Food GetFoodById(Guid id);
        void InsertFood(Food food);
        void DeleteFood(Guid id);
        void UpdateFood(Food food);
        void Save();
    }
}
