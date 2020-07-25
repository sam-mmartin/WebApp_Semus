using System.Threading.Tasks;
using WebApp_Semus.Data;
using WebApp_Semus.Models.Stock.Product;

namespace WebApp_Semus.GlobalMethods
{
    public class VerifyList
    {
        private readonly ApplicationDbContext _dbContext;
        public VerifyList(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<MedicamentViewModel> ReturnDescription(MedicamentViewModel model)
        {
            if (!string.IsNullOrEmpty(model.Section))
            {
                model.Section = (await _dbContext.Sections.FindAsync(model.Section)).Description;
            }

            if (!string.IsNullOrEmpty(model.PharmacologicalGroup))
            {
                model.PharmacologicalGroup = (await _dbContext.PharmacologicalGroups.FindAsync(model.PharmacologicalGroup)).Description;
            }

            if (!string.IsNullOrEmpty(model.FirstSubGroup))
            {
                model.FirstSubGroup = (await _dbContext.FirstSubGroups.FindAsync(model.FirstSubGroup)).Description;
            }

            if (!string.IsNullOrEmpty(model.SecondSubGroup))
            {
                model.SecondSubGroup = (await _dbContext.SecondSubGroups.FindAsync(model.SecondSubGroup)).Description;
            }

            if (!string.IsNullOrEmpty(model.ThirdSubGroup))
            {
                model.ThirdSubGroup = (await _dbContext.ThirdSubGroups.FindAsync(model.ThirdSubGroup)).Description;
            }

            return model;
        }
    }
}
