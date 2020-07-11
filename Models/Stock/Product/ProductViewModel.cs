using System.ComponentModel.DataAnnotations;

namespace WebApp_Semus.Models.Stock.Product
{
    public class ProductViewModel : BaseStockViewModel
    {
        public byte Type { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Categoria")]
        public string Category { get; set; }
    }
}
