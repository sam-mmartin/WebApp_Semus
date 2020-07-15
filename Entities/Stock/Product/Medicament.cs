using System.Collections.Generic;

namespace WebApp_Semus.Entities.Stock
{
    public class Medicament : Base
    {
        // Foreign Key PharmacologicalGroup
        public int PharmacologicalGroupID { get; set; }

        // Atributes
        public string PharmaceuticalForm { get; set; }
        public string Availability { get; set; }

        // Navegation Property
        public virtual PharmacologicalGroup PharmacologicalGroup { get; set; }
        public virtual ICollection<StockProduct> StockProducts { get; set; }
    }
}
