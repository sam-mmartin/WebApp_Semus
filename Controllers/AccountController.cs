using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp_Semus.Data;
using WebApp_Semus.Entities;
using WebApp_Semus.Lists;

namespace WebApp_Semus.Controllers
{
    //[Authorize(Policy = "SuperAdmin")]
    public class AccountController : Controller
    {
        #region Var & Constructor
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public AccountController(ApplicationDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        //public AccountController(UserManager<IdentityUser> userManager)
        //{
        //    _userManager = userManager;
        //}
        #endregion

        public async Task<IActionResult> Index()
        {
            var allUsers = new List<User>();
            List<IdentityUser> users = await _dbContext.Users.ToListAsync();
            foreach (var item in users)
            {
                var user = new User
                {
                    ID = item.Id,
                    Email = item.Email
                };
                allUsers.Add(user);
            }
            return View(allUsers);
        }

        public async Task<IActionResult> SetClaim(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                TempData["Message"] = "Usuário não encontrado.";
                return RedirectToAction("Index");
            }

            var searchUser = await _userManager.FindByIdAsync(id);
            var user = new User
            {
                ID = searchUser.Id,
                Email = searchUser.Email
            };

            ViewBag.ListClaims = new SelectList(Claims.ListClaims(), "Description", "Description");
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SetClaim(User user)
        {
            if (ModelState.IsValid)
            {
                var searchUser = await _userManager.FindByIdAsync(user.ID);

                if (searchUser == null)
                {
                    TempData["Message"] = "Usuário não encontrado!";
                    return RedirectToAction("Index");
                }

                var claimsUser = await _userManager.GetClaimsAsync(searchUser);

                if (claimsUser.Count == 0)
                {
                    _ = await _userManager.AddClaimAsync(searchUser, new Claim(user.Claim.Type, user.Claim.Value));
                }
                else
                {
                    foreach (var item in claimsUser)
                    {
                        if (user.Claim.Type.Equals(item.Type))
                        {
                            _ = await _userManager.ReplaceClaimAsync(searchUser, item, new Claim(user.Claim.Type, user.Claim.Value));
                        }
                    }
                }

                TempData["Message"] = "Nível de Acesso modificado.";
                return RedirectToAction("Index");
            }

            return View(user);
        }
    }
}
