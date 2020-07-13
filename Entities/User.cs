using WebApp_Semus.Models;

namespace WebApp_Semus.Entities
{
    public class User
    {
        public string ID { get; set; }
        public string Email { get; set; }
        public ClaimViewModel Claim { get; set; }
    }
}
