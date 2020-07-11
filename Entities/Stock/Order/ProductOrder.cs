using WebApp_Semus.Entities.Stock.Order;

namespace WebApp_Semus.Entities.Stock
{
    public class ProductOrder : BaseProduct
    {
        public int StockOrderID { get; set; }

        public virtual StockOrder StockOrder { get; set; }
    }
}
