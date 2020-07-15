using WebApp_Semus.Entities.Stock.Order;

namespace WebApp_Semus.Entities.Stock
{
    public class ProductOrder : BaseProduct
    {
        // Foreign Key StockOrder
        public int StockOrderID { get; set; }

        // Navegation Property
        public virtual StockOrder StockOrder { get; set; }
    }
}
