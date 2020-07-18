using System.ComponentModel.DataAnnotations;

namespace WebApp_Semus.Models.Stock.Product
{
    public class MedicamentViewModel : BaseStockViewModel
    {
        // Atributes
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [StringLength(100)]
        [Display(Name = "Forma Farmacêutica")]
        public string PharmaceuticalForm { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [StringLength(150)]
        [Display(Name = "Condição de uso")]
        public string Availability { get; set; }

        [StringLength(150)]
        [Display(Name = "Seção")]
        public string Section { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [StringLength(150)]
        [Display(Name = "Grupo Farmacológico")]
        public string PharmacologicalGroup { get; set; }

        [StringLength(150)]
        [Display(Name = "Subgrupo 1")]
        public string FirstSubGroup { get; set; }

        [StringLength(150)]
        [Display(Name = "Subgrupo 2")]
        public string SecondSubGroup { get; set; }

        [StringLength(150)]
        [Display(Name = "Subgrupo 3")]
        public string ThirdSubGroup { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [Display(Name = "Quantidade")]
        public int Quantity { get; set; }
    }
}
