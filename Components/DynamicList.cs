using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using WebApp_Semus.Lists;

namespace WebApp_Semus.Components
{
    public class DynamicList : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            return View(new SelectList(
                new PharmacologicalGroup().ListPharmacologicalGroup(), "Description", "Description"));
        }
    }
}
