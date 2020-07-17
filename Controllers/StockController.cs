using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebApp_Semus.Data;
using WebApp_Semus.Entities.Stock;
using WebApp_Semus.Models;
using WebApp_Semus.Models.Stock.Product;

namespace WebApp_Semus.Controllers
{
    [Authorize(Policy = "Admin")]
    public class StockController : Controller
    {
        #region Var & Constructor
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public StockController(ApplicationDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        #endregion

        #region Get Methods

        public async Task<IActionResult> Index()
        {
            return View(await _dbContext.Stocks.AsNoTracking().ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                TempData["Message"] = "Estoque não encontrado. " +
                    "Registro apagado por outro usuário.";
                return RedirectToAction("Index");
            }

            var stock = await _dbContext.Stocks
                .Where(s => s.ID == id)
                .Include(i => i.StockOrders)
                .Include(i => i.StockProducts)
                .ThenInclude(t => t.Medicament)
                .AsNoTracking().SingleOrDefaultAsync();

            if (stock.ID == 1)
            {
                ViewBag.Orders = new OrdersBagViewModel()
                {
                    CountProduct = await _dbContext.StockOrders.Where(p => p.Invoice == false).AsNoTracking().CountAsync()
                };
            }

            ViewBag.Stock = new StockBagViewModel()
            {
                ID = stock.ID,
                Description = stock.Name
            };
            return View(stock);
        }

        [Authorize(Policy = "SuperAdmin")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Policy = "SuperAdmin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                TempData["Message"] = "Registro do Estoque não encontrado. " +
                    "Verifique com o administrador se o problema persistir.";
                return RedirectToAction("Index");
            }

            var stock = await _dbContext.Stocks.FindAsync(id);
            var stockUpdate = new StockViewModel
            {
                ID = stock.ID,
                Name = stock.Name
            };

            return View(stockUpdate);
        }
        #endregion

        #region Post Methods

        [Authorize(Policy = "SuperAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StockViewModel model)
        {
            if (ModelState.IsValid)
            {
                _ = _dbContext.Stocks.Add(new Stock
                {
                    Name = model.Name,
                    UserID = _userManager.GetUserId(User),
                    DateRegister = DateTime.Now,
                    DateUpdate = DateTime.Now
                });
                _ = await _dbContext.SaveChangesAsync();

                TempData["Message"] = "Novo estoque criado com sucesso.";
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [Authorize(Policy = "SuperAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(StockViewModel model)
        {
            if (ModelState.IsValid)
            {
                var stockUpdate = await _dbContext.Stocks.FindAsync(model.ID);

                if (stockUpdate == null)
                {
                    TempData["Message"] = "Registro do Estoque não encontrado. " +
                        "Verifique com o administrador se o problema persistir.";
                    return RedirectToAction("Index");
                }

                if (await TryUpdateModelAsync(stockUpdate, "",
                    s => s.Name, s => s.DateUpdate, s => s.UserID))
                {
                    try
                    {
                        stockUpdate.DateUpdate = DateTime.Now;
                        stockUpdate.UserID = _userManager.GetUserId(User);
                        _ = await _dbContext.SaveChangesAsync();

                        TempData["Message"] = "Registro atualizado.";
                        return RedirectToAction("Details", new { id = model.ID });
                    }
                    catch (DbUpdateException)
                    {
                        ModelState.AddModelError("", "Não foi possível salvar as alterações. " +
                            "Tente novamente, se o problema persistir, " +
                            "entre em contato com o administrador do sistema.");
                    }
                }
            }

            return View(model);
        }
        #endregion
    }
}
