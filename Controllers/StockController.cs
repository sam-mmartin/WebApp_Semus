using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using WebApp_Semus.Data;
using WebApp_Semus.Entities.Stock;
using WebApp_Semus.Models.Stock.Product;

namespace WebApp_Semus.Controllers
{
    public class StockController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public StockController(ApplicationDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _dbContext.Stocks.ToListAsync());
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StockViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userID = _userManager.GetUserId(User);
                var newStock = new Stock
                {
                    Description = model.Description,
                    UserID = userID,
                    DateRegister = DateTime.Now,
                    DateUpdate = DateTime.Now
                };

                _ = _dbContext.Stocks.Add(newStock);
                _ = await _dbContext.SaveChangesAsync();
                TempData["Message"] = "Novo estoque criado com sucesso.";
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
