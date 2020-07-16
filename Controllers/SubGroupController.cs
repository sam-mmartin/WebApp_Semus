using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Json;
using WebApp_Semus.Data;
using WebApp_Semus.Lists;
using WebApp_Semus.Models;

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
                return Json(JsonSerializer.Serialize(new FirstSubGroup().ListFirstSubGroup()));
            }

            if (level == 2)
            {
                return Json(JsonSerializer.Serialize(new SecondSubGroup().ListSecondSubGroup()));
            }

            if (level == 3)
            {
                return Json(JsonSerializer.Serialize(new ThirdSubGroup().ListThirdSubGroup()));
            }

            var result = new { };
            return Json(result);
        }
    }
}
