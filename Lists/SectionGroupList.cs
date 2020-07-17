using System.Collections.Generic;

namespace WebApp_Semus.Lists
{
    public class SectionGroupList
    {
        public int ID { get; set; }
        public string Description { get; set; }

        public List<SectionGroupList> ListSectionGroup()
        {
            return new List<SectionGroupList>
            {
                new SectionGroupList{ID=1,Description="MEDICAMENTOS USADOS EM MANIFESTAÇÕES GERAIS DE DOENÇAS"},
                new SectionGroupList{ID=2,Description="MEDICAMENTOS USADOS EM DOENÇAS DE ORGÃOS E SISTEMAS ORGÂNICOS"}
            };
        }
    }
}
