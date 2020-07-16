using System.ComponentModel.DataAnnotations;

namespace WebApp_Semus.Models.Stock.Product
{
    public class MedicamentViewModel : BaseStockViewModel
    {
        // Atributes
        [Required]
        [StringLength(100)]
        [Display(Name = "Forma Farmacêutica")]
        public string PharmaceuticalForm { get; set; }

        [Required]
        [StringLength(150)]
        [Display(Name = "Condição de uso")]
        public string Availability { get; set; }

        [StringLength(150)]
        [Display(Name = "Seção")]
        public string Section { get; set; }

        [StringLength(150)]
        [Display(Name = "Grupo Farmacológico")]
        public string PharmacologicalGroup { get; set; }

        [StringLength(150)]
        [Display(Name = "Subgrupo")]
        public string FirstSubGroup { get; set; }

        [StringLength(150)]
        public string SecondSubGroup { get; set; }

        [StringLength(150)]
        public string ThirdSubGroup { get; set; }

        [Display(Name = "Quantidade")]
        public int Quantity { get; set; }
    }
}
