using System.ComponentModel.DataAnnotations;

namespace WebApp_Semus.Models.List
{
    public class PharmacologicalGroupViewModel : Base
    {
        [Display(Name = "Seção")]
        public int SectionID { get; set; }
    }
}
