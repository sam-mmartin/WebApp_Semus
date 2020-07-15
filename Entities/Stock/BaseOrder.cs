using Microsoft.AspNetCore.Identity;
using System;

namespace WebApp_Semus.Entities.Stock
{
    public class BaseOrder
    {
        // Key
        public int ID { get; set; }

        // Foreign Key
        public int StockID { get; set; }
        public string UserID { get; set; }

        // Atributes
        public bool Invoice { get; set; }
        public DateTime DateInput { get; set; }
        public DateTime DateInvoice { get; set; }

        // Navegation Property
        public virtual IdentityUser IdentityUser { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
