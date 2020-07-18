using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_Semus.Data;

namespace WebApp_Semus.Components
{
    public class SubDynamicList : ViewComponent
    {
        private readonly ApplicationDbContext _dbContext;

        public SubDynamicList(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(int? level, int? id)
        {
            if (id == null || level == null)
            {
                return View();
            }

            return level switch
            {
                1 => View(new SelectList(await _dbContext.FirstSubGroups.Where(f => f.PharmacologicalGroupID == id).ToListAsync(), "ID", "Description")),
                2 => View(new SelectList(await _dbContext.SecondSubGroups.Where(f => f.FirstSubGroupID == id).ToListAsync(), "ID", "Description")),
                3 => View(new SelectList(await _dbContext.ThirdSubGroups.Where(f => f.SecondSubGroupID == id).ToListAsync(), "ID", "Description")),
                _ => View(),
            };
        }
    }
}
