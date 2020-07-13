using System.Collections.Generic;

namespace WebApp_Semus.Lists
{
    public class Claims
    {
        public string Description { get; set; }

        public static List<Claims> ListClaims()
        {
            return new List<Claims>
            {
                new Claims{Description="Admin"}
            };
        }
    }
}
