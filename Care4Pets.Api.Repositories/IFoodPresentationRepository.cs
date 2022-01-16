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
        IEnumerable<FoodPresentation> GetFoodPresentations();
        FoodPresentation GetFoodPresentationById(int id);
        void InsertFoodPresentation(FoodPresentation foodPresentation);
        void DeleteFoodPresentation(int id);
        void UpdateFoodPresentation(FoodPresentation foodPresentation);
        void Save();
    }
}
