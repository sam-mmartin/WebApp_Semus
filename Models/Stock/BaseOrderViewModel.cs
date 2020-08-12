using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp_Semus.Models.Stock
{
    public class BaseOrderViewModel
    {
        // Key
        [HiddenInput]
        public int ID { get; set; }

        // Foreign Key
        [HiddenInput]
        public int StockID { get; set; }
        public string UserID { get; set; }

        // Atributes
        [Display(Name = "Faturado"), HiddenInput]
        public bool Invoice { get; set; }

        [DataType(DataType.Date), Editable(false)]
        [Display(Name = "Data de Registro")]
        public DateTime DateInput { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data da Fatura")]
        public DateTime DateInvoice { get; set; }
    }
}
