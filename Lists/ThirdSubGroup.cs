using System.Collections.Generic;

namespace WebApp_Semus.Lists
{
    public class ThirdSubGroup
    {
        public string Description { get; set; }

        public List<ThirdSubGroup> ListThirdSubGroup()
        {
            return new List<ThirdSubGroup>
            {
                new ThirdSubGroup{Description=""},
                new ThirdSubGroup{Description=""}
            };
        }
    }
}
