using System.ComponentModel.DataAnnotations;

namespace WebApp_Semus.Models.List
{
    public class Base
    {
        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        [Display(Name = "Descrição")]
        public string Description { get; set; }
    }
}
