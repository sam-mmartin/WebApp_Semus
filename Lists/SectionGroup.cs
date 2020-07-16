using System.Collections.Generic;

namespace WebApp_Semus.Lists
{
    public class SectionGroup
    {
        public string Description { get; set; }

        public List<SectionGroup> ListSectionGroup()
        {
            return new List<SectionGroup>
            {
                new SectionGroup{Description="MEDICAMENTOS USADOS EM MANIFESTAÇÕES GERAIS DE DOENÇAS"},
                new SectionGroup{Description="MEDICAMENTOS USADOS EM DOENÇAS DE ORGÃOS E SISTEMAS ORGÂNICOS"}
            };
        }
    }
}
