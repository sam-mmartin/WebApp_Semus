using System.ComponentModel.DataAnnotations;

namespace WebApp_Semus.Models.Stock.Product
{
    public class MedicamentViewModel : BaseStockViewModel
    {
        // Foreign Key
        public int PharmacologicalGroupID { get; set; }

        // Atributes
        [Required]
        [StringLength(100)]
        [Display(Name = "Forma Farmacêutica")]
        public string PharmaceuticalForm { get; set; }

        [Display(Name = "Condição de uso")]
        public string Availability { get; set; }

        [Display(Name = "Quantidade")]
        public int Quantity { get; set; }
    }
}
