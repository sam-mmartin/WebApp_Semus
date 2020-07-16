using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp_Semus.Data;
using WebApp_Semus.Entities.Stock;
using WebApp_Semus.GlobalMethods;
using WebApp_Semus.Lists;
using WebApp_Semus.Models;
using WebApp_Semus.Models.Stock.Product;

namespace WebApp_Semus.Controllers
{
    //[Authorize(Policy = "Admin")]
    public class MedicamentController : Controller
    {
        #region Var & Constructor
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public MedicamentController(ApplicationDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        #endregion

        #region Get Methods

        public async Task<IActionResult> Index(int stockID, string currentFilter, string searchString, int? pageNumber)
        {
            var stock = await _dbContext.Stocks.FindAsync(stockID);

            var products = _dbContext.StockProducts
                .Where(s => s.StockID == stockID)
                .Include(p => p.Medicament)
                .Include(u => u.IdentityUser)
                .Select(s => s);

            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(p => p.Medicament.Name.Contains(searchString));
            }

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                currentFilter = searchString;
            }

            ViewBag.Stock = new StockBagViewModel()
            {
                ID = stock.ID,
                Description = stock.Name
            };

            ViewData["CurrentFilter"] = searchString;
            int pageSize = 6;
            return View(await PaginatedList<StockProduct>.CreateAsync(products, pageNumber ?? 1, pageSize));
        }

        public async Task<IActionResult> Details(string currentFilter, string searchString, int? pageNumber)
        {
            var allProducts = _dbContext.Medicaments
                .Include(s => s.StockProducts)
                .ThenInclude(s => s.Stock)
                .Select(s => s);

            if (!string.IsNullOrEmpty(searchString))
            {
                allProducts = allProducts.Where(p => p.Name.Contains(searchString));
            }

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                currentFilter = searchString;
            }

            ViewData["CurrentFilter"] = searchString;
            int pageSize = 10;
            return View(await PaginatedList<Medicament>.CreateAsync(allProducts, pageNumber ?? 1, pageSize));
        }

        //[Authorize(Policy = "SuperAdmin")]
        public IActionResult Create()
        {
            ViewBag.Section = new SelectList(
                new SectionGroup().ListSectionGroup(), "Description", "Description");
            ViewBag.Group = new SelectList(
                new PharmacologicalGroup().ListPharmacologicalGroup(), "Description", "Description");
            return View();
        }
        #endregion

        #region Post Methods

        //[Authorize(Policy = "SuperAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MedicamentViewModel model)
        //public IActionResult Create(MedicamentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userID = _userManager.GetUserId(User);
                var newProduct = new Medicament
                {
                    Name = model.Name,
                    PharmaceuticalForm = model.PharmaceuticalForm,
                    Availability = model.Availability,
                    Section = model.Section,
                    PharmacologicalGroup = model.PharmacologicalGroup,
                    UserID = userID
                };

                if (!string.IsNullOrEmpty(model.FirstSubGroup))
                {
                    newProduct.FirstSubGroup = model.FirstSubGroup;
                }

                if (!string.IsNullOrEmpty(model.SecondSubGroup))
                {
                    newProduct.SecondSubGroup = model.SecondSubGroup;
                }

                if (!string.IsNullOrEmpty(model.ThirdSubGroup))
                {
                    newProduct.ThirdSubGroup = model.ThirdSubGroup;
                }

                _ = _dbContext.Medicaments.Add(newProduct);
                _ = await _dbContext.SaveChangesAsync();

                var newStockProduct = new StockProduct
                {
                    MedicamentID = newProduct.ID,
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
                return RedirectToAction("Index", new { stockID = 1 });
            }

            return View(model);
        }
        #endregion

        public IActionResult DynamicList(string description)
        {
            return ViewComponent("DynamicList", description);
        }
    }
}
