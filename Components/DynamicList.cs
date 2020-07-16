using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using WebApp_Semus.Lists;

namespace WebApp_Semus.Components
{
    public class DynamicList : ViewComponent
    {
        public IViewComponentResult Invoke(string description)
        {
            if (!string.IsNullOrEmpty(description))
            {
                var sectionID = new SectionGroup().ListSectionGroup()
                    .SingleOrDefault(s => s.Description == description).ID;
                return View(new SelectList(new PharmacologicalGroup().ListPharmacologicalGroup()
                    .Where(l => l.ID == sectionID), "Description", "Description"));
            }

            return View(new SelectList(new PharmacologicalGroup().ListPharmacologicalGroup(),
                                       "Description",
                                       "Description"));
        }
    }
}
