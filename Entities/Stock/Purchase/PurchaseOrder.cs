using System.Collections.Generic;

namespace WebApp_Semus.Entities.Stock.Purchase
{
    public class PurchaseOrder : BaseOrder
    {
        // Navegation Property
        public virtual ICollection<ProductPurchaseOrder> ProductPurchaseOrders { get; set; }
    }
}
