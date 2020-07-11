using System;
using System.Collections.Generic;
using WebApp_Semus.Entities.Stock.Order;
using WebApp_Semus.Entities.Stock.Purchase;

namespace WebApp_Semus.Entities.Stock
{
    public class Stock : Base
    {
        public DateTime DateRegister { get; set; }
        public DateTime DateUpdate { get; set; }

        public virtual ICollection<StockProduct> StockProducts { get; set; }
        public virtual ICollection<StockOrder> StockOrders { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
