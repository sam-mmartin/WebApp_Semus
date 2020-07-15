using System.Collections.Generic;

namespace WebApp_Semus.Entities.Stock
{
    public class Medicament : Base
    {
        public int PharmacologicalGroupID { get; set; }
        public string PharmaceuticalForm { get; set; }
        public string Availability { get; set; }

        public virtual PharmacologicalGroup PharmacologicalGroup { get; set; }
        public virtual ICollection<StockProduct> StockProducts { get; set; }
    }
}
