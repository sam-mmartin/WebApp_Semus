namespace WebApp_Semus.Entities.Stock.Purchase
{
    public class ProductPurchaseOrder : BaseProduct
    {
        public int PurchaseOrderID { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
