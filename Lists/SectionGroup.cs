using System.Collections.Generic;

namespace WebApp_Semus.Lists
{
    public class SectionGroup
    {
        public string ID { get; set; }
        public string Description { get; set; }

        public static List<SectionGroup> ListSectionGroup()
        {
            return new List<SectionGroup>
            {
                new SectionGroup{ID="A", Description="MEDICAMENTOS USADOS EM MANIFESTAÇÕES GERAIS DE DOENÇAS"},
                new SectionGroup{ID="B", Description="MEDICAMENTOS USADOS EM DOENÇAS DE ORGÃOS E SISTEMAS ORGÂNICOS"}
            };
        }
    }
}
