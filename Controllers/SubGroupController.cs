using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebApp_Semus.Data;
using WebApp_Semus.Lists;

namespace WebApp_Semus.Controllers
{
    public class SubGroupController : Controller
    {
        #region Var & Constructor
        private readonly ApplicationDbContext _dbContext;

        public SubGroupController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        public JsonResult Add(int level)
        {
            if (level == 1)
            {
                return Json(JsonSerializer.Serialize(new FirstSubGroupList().ListFirstSubGroup()));
            }

            if (level == 2)
            {
                return Json(JsonSerializer.Serialize(new SecondSubGroupList().ListSecondSubGroup()));
            }

            if (level == 3)
            {
                return Json(JsonSerializer.Serialize(new ThirdSubGroupList().ListThirdSubGroup()));
            }

            var result = new { };
            return Json(result);
        }
    }
}
