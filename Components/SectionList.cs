using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApp_Semus.Data;

namespace WebApp_Semus.Components
{
    public class SectionList : ViewComponent
    {
        private readonly ApplicationDbContext _dbContext;
        public SectionList(ApplicationDbContext dbContext) => _dbContext = dbContext;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _dbContext.Sections.Select(s => s.Description).ToListAsync());
        }
    }
}
