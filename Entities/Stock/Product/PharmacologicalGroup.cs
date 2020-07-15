using System.Collections.Generic;

namespace WebApp_Semus.Entities.Stock
{
    public class PharmacologicalGroup : Base
    {
        // Atributes
        public string Section { get; set; }
        public string SectionName { get; set; }

        public string FirstSubGroup { get; set; }
        public string SecondSubGroup { get; set; }
        public string ThirdSubGroup { get; set; }

        public string FirstGroupName { get; set; }
        public string SecondGroupName { get; set; }
        public string ThirdGroupName { get; set; }

        // Navegation Property
        public virtual ICollection<Medicament> Medicaments { get; set; }
    }
}
