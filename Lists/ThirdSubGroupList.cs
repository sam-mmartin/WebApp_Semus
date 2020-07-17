using System.Collections.Generic;

namespace WebApp_Semus.Lists
{
    public class ThirdSubGroupList
    {
        public int ID { get; set; }
        public int SecondID { get; set; }
        public string Description { get; set; }

        public List<ThirdSubGroupList> ListThirdSubGroup()
        {
            return new List<ThirdSubGroupList>
            {
                new ThirdSubGroupList{ID=1,SecondID=15,Description="amebicida, giardicida e tricomicida"}
            };
        }
    }
}
