using Microsoft.AspNetCore.Identity;

namespace WebApp_Semus.Entities.Stock
{
    public class Base
    {
        // Key
        public int ID { get; set; }

        // Foreign Key IdentityUser
        public string UserID { get; set; }

        // Atributes
        public string Name { get; set; }

        // Navegation Property
        public virtual IdentityUser IdentityUser { get; set; }
    }
}
