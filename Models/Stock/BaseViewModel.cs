using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp_Semus.Models.Stock
{
    public class BaseStockViewModel
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Descrição")]
        public string Description { get; set; }
    }

    public class BaseOrderViewModel
    {
        public int ID { get; set; }
        public int StockID { get; set; }
        public string UserID { get; set; }

        public byte Type { get; set; }
        [Display(Name = "Faturado")]
        public bool Invoice { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Registro")]
        public DateTime DateInput { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data da Fatura")]
        public DateTime DateInvoice { get; set; }
    }

    public class BaseProductViewModel
    {
        public int ProductID { get; set; }
        [Required]
        [Display(Name = "Quantidade")]
        public int Quantity { get; set; }
    }
}
