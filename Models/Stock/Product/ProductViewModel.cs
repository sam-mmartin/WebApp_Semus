using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApp_Semus.Models.Stock.Product
{
    public class ProductViewModel : BaseStockViewModel
    {
        [HiddenInput]
        public byte Type { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Categoria")]
        public string Category { get; set; }
    }
}
