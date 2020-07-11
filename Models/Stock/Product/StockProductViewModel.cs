﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp_Semus.Models.Stock.Product
{
    public class StockProductViewModel
    {
        public int StockID { get; set; }
        public int ProductID { get; set; }
        public string UserID { get; set; }

        [Display(Name = "Total")]
        public int TotalQuantity { get; set; }
        [Display(Name = "Última Entrada")]
        public int InputQuantity { get; set; }
        [Display(Name = "Última Saída")]
        public int OutputQuantity { get; set; }
        public int MissingQuantity { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data da Última Entrada")]
        public DateTime DateInput { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data da Última Saída")]
        public DateTime DateOutput { get; set; }
    }
}
