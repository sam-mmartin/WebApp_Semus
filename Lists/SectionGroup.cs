using System.Collections.Generic;

namespace WebApp_Semus.Lists
{
    public class SectionGroup
    {
        public int ID { get; set; }
        public string Description { get; set; }

        public List<SectionGroup> ListSectionGroup()
        {
            return new List<SectionGroup>
            {
                new SectionGroup{ID=1,Description="MEDICAMENTOS USADOS EM MANIFESTAÇÕES GERAIS DE DOENÇAS"},
                new SectionGroup{ID=2,Description="MEDICAMENTOS USADOS EM DOENÇAS DE ORGÃOS E SISTEMAS ORGÂNICOS"}
            };
        }
    }
}
