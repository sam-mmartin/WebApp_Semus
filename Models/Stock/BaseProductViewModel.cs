using System.ComponentModel.DataAnnotations;

namespace WebApp_Semus.Models.Stock
{
    public class BaseProductViewModel
    {
        // Key
        public int ProductID { get; set; }

        // Atributes
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [Display(Name = "Quantidade")]
        public int Quantity { get; set; }
    }
}
