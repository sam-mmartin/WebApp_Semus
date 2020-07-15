using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp_Semus.Data;
using WebApp_Semus.Entities.Stock;
using WebApp_Semus.GlobalMethods;
using WebApp_Semus.Models.Stock.Product;

namespace WebApp_Semus.Controllers
{
    public class PharmacologicalGroupController : Controller
    {
        #region Var & Constructor
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public PharmacologicalGroupController(ApplicationDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        #endregion

        #region Get Methods
        public async Task<IActionResult> Index(
            string currentFilter,
            string searchString,
            int? pageNumber)
        {
            var pharma_group = _dbContext.PharmacologicalGroups.Select(p => p);

            if (!string.IsNullOrEmpty(searchString))
            {
                pharma_group = pharma_group.Where(p => p.Name.Contains(searchString));
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
            return View(await PaginatedList<PharmacologicalGroup>.CreateAsync(pharma_group, pageNumber ?? 1, pageSize));
        }

        public IActionResult Create()
        {
            return View();
        }
        #endregion

        #region Post Methods

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(PharmaGroupViewModel model)
        //{

        //}
        #endregion
    }
}
