using Microsoft.AspNetCore.Identity;

namespace WebApp_Semus.Entities.Stock
{
    public class Base
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string Description { get; set; }

        public virtual IdentityUser IdentityUser { get; set; }
    }
}
