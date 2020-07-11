using System.Collections.Generic;

namespace WebApp_Semus.Entities.Stock
{
    public class Product : Base
    {
        public byte Type { get; set; }
        public string Category { get; set; }

        public virtual ICollection<StockProduct> StockProducts { get; set; }
    }
}
