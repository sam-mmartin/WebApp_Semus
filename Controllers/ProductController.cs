using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp_Semus.Data;
using WebApp_Semus.Entities.Stock;
using WebApp_Semus.Models;
using WebApp_Semus.Models.Stock.Product;

namespace WebApp_Semus.Controllers
{
    [Authorize(Policy = "Admin")]
    public class ProductController : Controller
    {
        #region Var & Constructor
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public ProductController(ApplicationDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        #endregion

        #region Get Methods
        public async Task<IActionResult> Index(int stockID, byte type)
        {
            var stock = await _dbContext.Stocks
                .Where(s => s.ID == stockID)
                .Include(t => t.StockProducts)
                .ThenInclude(p => p.Product)
                .ThenInclude(i => i.IdentityUser)
                .SingleOrDefaultAsync();

            var products = stock.StockProducts
                .Where(s => s.Product.Type == type);

            ViewBag.Stock = new StockBagViewModel()
            {
                ID = stock.ID,
                Description = stock.Description
            };

            ViewBag.Type = type;
            return View(products);
        }

        [Authorize(Policy = "SuperAdmin")]
        public IActionResult Create(byte type)
        {
            return base.View(new ProductViewModel
            {
                Type = type
            });
        }
        #endregion

        #region Post Methods
        [Authorize(Policy = "SuperAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userID = _userManager.GetUserId(User);
                var newProduct = new Product
                {
                    Category = model.Category,
                    Description = model.Description,
                    Type = model.Type,
                    UserID = userID
                };

                _ = _dbContext.Products.Add(newProduct);
                _ = await _dbContext.SaveChangesAsync();

                var newStockProduct = new StockProduct
                {
                    ProductID = newProduct.ID,
                    StockID = 1,
                    DateInput = DateTime.Now,
                    DateOutput = DateTime.MinValue,
                    UserID = userID,
                    InputQuantity = model.Quantity,
                    OutputQuantity = 0,
                    MissingQuantity = 0,
                    TotalQuantity = model.Quantity
                };

                _ = _dbContext.StockProducts.Add(newStockProduct);
                _ = await _dbContext.SaveChangesAsync();

                TempData["Message"] = "Produto adicionado ao estoque.";
                return RedirectToAction("Index", new { stockID = 1, type = model.Type });
            }

            return View(model);
        }
        #endregion
    }
}
