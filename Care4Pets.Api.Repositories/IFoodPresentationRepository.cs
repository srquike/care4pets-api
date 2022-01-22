using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Repositories
{
    public interface IFoodPresentationRepository
    {
        Task<IEnumerable<FoodPresentation>> GetFoodPresentations();
        Task<FoodPresentation> GetFoodPresentationById(int id);
        Task<int> InsertFoodPresentation(FoodPresentation foodPresentation);
        Task<int> DeleteFoodPresentation(int id);
        Task<int> UpdateFoodPresentation(FoodPresentation foodPresentation);
        Task<int> Save();
    }
}
