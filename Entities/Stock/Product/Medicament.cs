using System.Collections.Generic;

namespace WebApp_Semus.Entities.Stock
{
    public class Medicament : Base
    {
        // Atributes
        public string PharmaceuticalForm { get; set; }
        public string Availability { get; set; }

        public string Section { get; set; }
        public string PharmacologicalGroup { get; set; }
        public string FirstSubGroup { get; set; }
        public string SecondSubGroup { get; set; }
        public string ThirdSubGroup { get; set; }

        // Navegation Property
        public virtual ICollection<StockProduct> StockProducts { get; set; }
    }
}
