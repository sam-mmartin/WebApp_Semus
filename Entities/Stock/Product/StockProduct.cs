using Microsoft.AspNetCore.Identity;
using System;

namespace WebApp_Semus.Entities.Stock
{
    public class StockProduct
    {
        // Foreign Key
        public int StockID { get; set; }
        public int MedicamentID { get; set; }
        public string UserID { get; set; }

        // Atributes
        public int TotalQuantity { get; set; }
        public int InputQuantity { get; set; }
        public int OutputQuantity { get; set; }
        public int MissingQuantity { get; set; }

        public DateTime DateInput { get; set; }
        public DateTime DateOutput { get; set; }

        // Navegation Property
        public virtual IdentityUser IdentityUser { get; set; }
        public virtual Medicament Medicament { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
