using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp_Semus.Data;

namespace WebApp_Semus.Controllers
{
    public class VerificationsController : Controller
    {
        #region Var & Constructor
        private readonly ApplicationDbContext _dbContext;
        public VerificationsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        public async Task<IActionResult> MedicamentAvailability(int id, int quantity)
        {
            var product = await _dbContext.StockProducts
                .Where(m => m.MedicamentID == id && m.StockID == 1)
                .Include(m => m.Medicament)
                .SingleOrDefaultAsync();

            if (quantity <= product.TotalQuantity)
            {
                return Json(new { Permitir = true });
            }
            else
            {
                return Json(new { Permitir = false, Name = product.Medicament.Name, Quantity = product.TotalQuantity });
            }
        }
    }
}
