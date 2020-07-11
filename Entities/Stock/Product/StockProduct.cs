using Microsoft.AspNetCore.Identity;
using System;

namespace WebApp_Semus.Entities.Stock
{
    public class StockProduct
    {
        public int StockID { get; set; }
        public int ProductID { get; set; }
        public string UserID { get; set; }

        public int TotalQuantity { get; set; }
        public int InputQuantity { get; set; }
        public int OutputQuantity { get; set; }
        public int MissingQuantity { get; set; }

        public DateTime DateInput { get; set; }
        public DateTime DateOutput { get; set; }

        public virtual IdentityUser IdentityUser { get; set; }
        public virtual Product Product { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
