using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp_Semus.Data;
using WebApp_Semus.Models;
using WebApp_Semus.Models.Stock.Order;

namespace WebApp_Semus.Controllers
{
    public class OrderController : Controller
    {
        #region Var & Constructor
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public OrderController(ApplicationDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        #endregion

        public async Task<IActionResult> Index(int stockID)
        {
            var stock = await _dbContext.Stocks.FindAsync(stockID);
            var orders = stockID == 1
                ? await _dbContext.StockOrders.ToListAsync()
                : await _dbContext.StockOrders.Where(o => o.StockID == stockID).ToListAsync();

            ViewBag.Stock = new StockBagViewModel()
            {
                ID = stock.ID,
                Description = stock.Name
            };
            return View(orders);
        }

        public async Task<IActionResult> Create(int stockID)
        {
            var newStockOrder = new StockOrderViewModel
            {
                StockID = stockID,
                Invoice = false
            };

            return View(newStockOrder);
        }
    }
}
