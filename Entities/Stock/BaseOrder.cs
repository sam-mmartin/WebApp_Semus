using Microsoft.AspNetCore.Identity;
using System;

namespace WebApp_Semus.Entities.Stock
{
    public class BaseOrder
    {
        public int ID { get; set; }
        public int StockID { get; set; }
        public string UserID { get; set; }

        public byte Type { get; set; }
        public bool Invoice { get; set; }
        public DateTime DateInput { get; set; }
        public DateTime DateInvoice { get; set; }

        public virtual IdentityUser IdentityUser { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
