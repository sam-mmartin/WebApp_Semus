using System.Collections.Generic;

namespace WebApp_Semus.Entities.Stock.Order
{
    public class StockOrder : BaseOrder
    {
        // Navegation Property
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
