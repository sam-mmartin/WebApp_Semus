namespace WebApp_Semus.Entities.Stock
{
    public class BaseProduct
    {
        public int StockProductID { get; set; }
        public int Quantity { get; set; }

        public virtual StockProduct StockProduct { get; set; }
    }
}
