using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp_Semus.Data;

namespace WebApp_Semus.Controllers
{
    public class AutoCompletesController : Controller
    {
        #region Var & Constructor
        private readonly ApplicationDbContext _dbContext;

        public AutoCompletesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        public async Task<IActionResult> AutoCompleteMedicament(string term)
        {
            return Json(
                await _dbContext.Medicaments.Where(m => m.Name.StartsWith(term))
                                            .Select(m => $"{m.ID} - {m.Name} - {m.PharmaceuticalForm}")
                                            .Take(10)
                                            .ToListAsync()
                );
        }
    }
}
