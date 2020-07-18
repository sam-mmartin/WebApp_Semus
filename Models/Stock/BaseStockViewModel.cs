using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApp_Semus.Models.Stock
{
    public class BaseStockViewModel
    {
        // Key
        [HiddenInput]
        public int ID { get; set; }

        // Foreign Key
        public string UserID { get; set; }

        // Atributes
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [StringLength(100)]
        [Display(Name = "Descrição")]
        public string Name { get; set; }
    }
}
