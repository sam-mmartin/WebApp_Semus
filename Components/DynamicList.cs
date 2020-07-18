using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApp_Semus.Data;

namespace WebApp_Semus.Components
{
    public class DynamicList : ViewComponent
    {
        private readonly ApplicationDbContext _dbContext;

        public DynamicList(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(int? id)
        {
            if (id == null)
            {
                return View();
            }

            return View(new SelectList(await _dbContext.PharmacologicalGroups.Where(p => p.SectionID == id).ToListAsync(),
                                       "ID", "Description"));
        }
    }
}
