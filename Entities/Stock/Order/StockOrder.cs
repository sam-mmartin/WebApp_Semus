using System.Collections.Generic;

namespace WebApp_Semus.Entities.Stock.Order
{
    public class StockOrder : BaseOrder
    {
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
