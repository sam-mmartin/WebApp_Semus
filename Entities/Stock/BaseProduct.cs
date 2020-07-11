namespace WebApp_Semus.Entities.Stock
{
    public class BaseProduct
    {
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
    }
}
