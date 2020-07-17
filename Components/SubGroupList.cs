using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_Semus.Data;
using WebApp_Semus.Models.List;

namespace WebApp_Semus.Components
{
    public class SubGroupList : ViewComponent
    {
        private readonly ApplicationDbContext _dbContext;
        public SubGroupList(ApplicationDbContext dbContext) => _dbContext = dbContext;

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            List<string> model = new List<string>();

            if (id == 1)
            {
                model = await _dbContext.FirstSubGroups.Select(s => s.Description)
                                                       .ToListAsync();
            }

            if (id == 2)
            {
                model = await _dbContext.SecondSubGroups.Select(s => s.Description)
                                                        .ToListAsync();
            }

            if (id == 3)
            {
                model = await _dbContext.ThirdSubGroups.Select(s => s.Description)
                                                       .ToListAsync();
            }

            return View(model);
        }
    }
}
