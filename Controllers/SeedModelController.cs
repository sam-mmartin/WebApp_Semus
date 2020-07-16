using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp_Semus.Data;
using WebApp_Semus.Entities.Stock;

namespace WebApp_Semus.Controllers
{
    public class SeedModelController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public SeedModelController(
            ApplicationDbContext dbContext,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _dbContext = dbContext;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<object> SeedingContext()
        {
            var user = new IdentityUser
            {
                UserName = "sam.c3tech@gmail.com",
                Email = "sam.c3tech@gmail.com"
            };
            var result = await _userManager.CreateAsync(user, "Lord0101#");

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);

                var newStock = new Stock
                {
                    Name = "Geral",
                    DateRegister = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    UserID = _userManager.GetUserId(User)
                };

                _ = _dbContext.Stocks.Add(newStock);
                _ = await _dbContext.SaveChangesAsync();
            }

            return TempData["Message"] = "Semente inicial criada!";
        }
    }
}
