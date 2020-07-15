namespace WebApp_Semus.Entities.Stock.Purchase
{
    public class ProductPurchaseOrder : BaseProduct
    {
        // Foreign Key PurchaseOrder
        public int PurchaseOrderID { get; set; }

        // Navegation Property
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
