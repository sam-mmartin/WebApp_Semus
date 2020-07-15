using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace WebApp_Semus.Entities.Stock
{
    public class PharmacologicalGroup
    {
        public int ID { get; set; }
        public string UserID { get; set; }

        public string FirstSubGroup { get; set; }
        public string SecondSubGroup { get; set; }
        public string ThirdSubGroup { get; set; }

        public string GroupName { get; set; }
        public string FirstGroupName { get; set; }
        public string SecondGroupName { get; set; }
        public string ThirdGroupName { get; set; }

        public virtual IdentityUser IdentityUser { get; set; }
        public virtual ICollection<Medicament> Medicaments { get; set; }
    }
}
