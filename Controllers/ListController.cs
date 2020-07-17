using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApp_Semus.Data;
using WebApp_Semus.Entities.Lists;
using WebApp_Semus.Lists;
using WebApp_Semus.Models.List;

namespace WebApp_Semus.Controllers
{
    [Authorize(Policy = "Admin")]
    public class ListController : Controller
    {
        #region Var & Constructor
        private readonly ApplicationDbContext _dbContext;

        public ListController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        #region Get Create
        public IActionResult CreateSection()
        {
            return View();
        }

        public async Task<IActionResult> CreateGroup()
        {
            ViewBag.Section = new SelectList(
                await _dbContext.Sections.OrderBy(s => s.ID).ToListAsync(),
                "ID",
                "Description");
            return View();
        }

        public async Task<IActionResult> CreateSubGroup(int id)
        {
            if (id == 1)
            {
                ViewBag.List = new SelectList(
                    await _dbContext.PharmacologicalGroups.OrderBy(s => s.ID).ToListAsync(),
                    "ID",
                    "Description");
            }

            if (id == 2)
            {
                ViewBag.List = new SelectList(
                    await _dbContext.FirstSubGroups.OrderBy(s => s.ID).ToListAsync(),
                    "ID",
                    "Description");
            }

            if (id == 3)
            {
                ViewBag.List = new SelectList(
                    await _dbContext.SecondSubGroups.OrderBy(s => s.ID).ToListAsync(),
                    "ID",
                    "Description");
            }

            return View(new SubGroupViewModel { GroupID = id });
        }
        #endregion

        #region Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateSection(SectionViewModel model)
        {
            if (ModelState.IsValid)
            {
                _ = _dbContext.Sections.Add(new Section
                {
                    Description = model.Description.ToUpper()
                });
                _ = await _dbContext.SaveChangesAsync();

                TempData["Message"] = "Seção adicionada.";
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateGroup(PharmacologicalGroupViewModel model)
        {
            if (ModelState.IsValid)
            {
                _ = _dbContext.PharmacologicalGroups.Add(new PharmacologicalGroup
                {
                    Description = model.Description.ToUpper(),
                    SectionID = model.SectionID
                });
                _ = await _dbContext.SaveChangesAsync();

                TempData["Message"] = "Grupo Farmacológico adicionado.";
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateSubGroup(SubGroupViewModel model)
        {
            if (ModelState.IsValid)
            {
                switch (model.GroupID)
                {
                    case 1:
                        _ = _dbContext.FirstSubGroups.Add(new FirstSubGroup
                        {
                            Description = model.Description.ToUpper(),
                            PharmacologicalGroupID = model.ForeignKey
                        });
                        break;
                    case 2:
                        _ = _dbContext.SecondSubGroups.Add(new SecondSubGroup
                        {
                            Description = model.Description.ToUpper(),
                            FirstSubGroupID = model.ForeignKey
                        });
                        break;
                    case 3:
                        _ = _dbContext.ThirdSubGroups.Add(new ThirdSubGroup
                        {
                            Description = model.Description.ToUpper(),
                            SecondSubGroupID = model.ForeignKey
                        });
                        break;
                    default:
                        return View(model);
                }

                _ = await _dbContext.SaveChangesAsync();
                TempData["Message"] = "Subgrupo adicionado.";
                return RedirectToAction("Index");
            }

            return View(model);
        }
        #endregion

        #region Initial Seed
        public async Task<IActionResult> SeedingContext()
        {
            var sectionList = new SectionGroupList().ListSectionGroup().OrderBy(s => s.ID);
            var groupList = new PharmacologicalGroupList().ListPharmacologicalGroup().OrderBy(s => s.ID);
            var firstList = new FirstSubGroupList().ListFirstSubGroup().OrderBy(s => s.ID);
            var secondList = new SecondSubGroupList().ListSecondSubGroup().OrderBy(s => s.ID);
            var thirdList = new ThirdSubGroupList().ListThirdSubGroup().OrderBy(s => s.ID);

            foreach (var item in sectionList)
            {
                var searchItem = await _dbContext.Sections.FindAsync(item.ID);

                if (searchItem == null)
                {
                    _ = _dbContext.Sections.Add(new Section
                    {
                        Description = item.Description
                    });
                    _ = await _dbContext.SaveChangesAsync();
                }
            }

            foreach (var item in groupList)
            {
                var searchItem = await _dbContext.PharmacologicalGroups.FindAsync(item.ID);
                if (searchItem == null)
                {
                    _ = _dbContext.PharmacologicalGroups.Add(new PharmacologicalGroup
                    {
                        SectionID = item.ForeignKey,
                        Description = item.Description
                    });
                    _ = await _dbContext.SaveChangesAsync();
                }
            }

            foreach (var item in firstList)
            {
                var searchItem = await _dbContext.FirstSubGroups.FindAsync(item.ID);
                if (searchItem == null)
                {
                    _ = _dbContext.FirstSubGroups.Add(new FirstSubGroup
                    {
                        PharmacologicalGroupID = item.GroupID,
                        Description = item.Description.ToUpper()
                    });
                    _ = await _dbContext.SaveChangesAsync();
                }
            }

            foreach (var item in secondList)
            {
                var searchItem = await _dbContext.SecondSubGroups.FindAsync(item.ID);
                if (searchItem == null)
                {
                    _ = _dbContext.SecondSubGroups.Add(new SecondSubGroup
                    {
                        FirstSubGroupID = item.FirstID,
                        Description = item.Description.ToUpper()
                    });
                    _ = await _dbContext.SaveChangesAsync();
                }
            }

            foreach (var item in thirdList)
            {
                var searchItem = await _dbContext.ThirdSubGroups.FindAsync(item.ID);
                if (searchItem == null)
                {
                    _ = _dbContext.ThirdSubGroups.Add(new ThirdSubGroup
                    {
                        SecondSubGroupID = item.SecondID,
                        Description = item.Description.ToUpper()
                    });
                    _ = await _dbContext.SaveChangesAsync();
                }
            }

            TempData["Message"] = "Seed efeutado com sucesso.";
            return RedirectToAction("Index");
        }
        #endregion
    }
}
