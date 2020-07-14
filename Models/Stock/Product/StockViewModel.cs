using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp_Semus.Models.Stock.Product
{
    public class StockViewModel : BaseStockViewModel
    {
        [Editable(false)]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Registro")]
        public DateTime DateRegister { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Última Atualização")]
        public DateTime DateUpdate { get; set; }
    }
}
