using System.Collections.Generic;

namespace WebApp_Semus.Lists
{
    public class FirstSubGroupList
    {
        public int ID { get; set; }
        public int GroupID { get; set; }
        public string Description { get; set; }

        public List<FirstSubGroupList> ListFirstSubGroup()
        {
            return new List<FirstSubGroupList>
            {
                new FirstSubGroupList{ID=1,GroupID=1,Description="Medicamentos Adjuvantes usados em procedimentos anestésicos de curta duração"},
                new FirstSubGroupList{ID=2,GroupID=1,Description="Anestésicos locais"},
                new FirstSubGroupList{ID=3,GroupID=2,Description="Analgésicos e antipiréticos"},
                new FirstSubGroupList{ID=4,GroupID=2,Description="Medicamentos para alívio da enxaqueca"},
                new FirstSubGroupList{ID=5,GroupID=4,Description="Anti-inflamatórios não-esteroides"},
                new FirstSubGroupList{ID=6,GroupID=4,Description="Anti-infamatórios esteroides"},
                new FirstSubGroupList{ID=7,GroupID=4,Description="Medicamentos para o tratamento da gota"},
                new FirstSubGroupList{ID=8,GroupID=6,Description="Antibacterianos"},
                new FirstSubGroupList{ID=9,GroupID=6,Description="Medicamentos para tratamento de endemias focais"},
                new FirstSubGroupList{ID=10,GroupID=6,Description="Antifúngicos"},
                new FirstSubGroupList{ID=11,GroupID=6,Description="Antivirais"},
                new FirstSubGroupList{ID=12,GroupID=6,Description="Antiparasitários"},
                new FirstSubGroupList{ID=13,GroupID=6,Description="Antissépticos, desinfetantes e esterilizantes"},
                new FirstSubGroupList{ID=14,GroupID=7,Description="Imunossupressores"},
                new FirstSubGroupList{ID=15,GroupID=8,Description="Não-específicos"},
                new FirstSubGroupList{ID=16,GroupID=8,Description="Específicos"},
                new FirstSubGroupList{ID=17,GroupID=12,Description="Anticonculsivantes"},
                new FirstSubGroupList{ID=18,GroupID=12,Description="Antidepressivos e estabilizadores de humor"},
                new FirstSubGroupList{ID=19,GroupID=12,Description="Antipsicóticos e adjuvantes"},
                new FirstSubGroupList{ID=20,GroupID=12,Description="Ansiolíticos e hipnossedativos"},
                new FirstSubGroupList{ID=21,GroupID=13,Description="Medicamentos utilizados na insuficiência cardíaca e choque cardiovascular"},
                new FirstSubGroupList{ID=22,GroupID=13,Description="Medicamentos antiarrítmicos"},
                new FirstSubGroupList{ID=23,GroupID=13,Description="Medicamentos usados em cardiopatia isquêmica"},
                new FirstSubGroupList{ID=24,GroupID=13,Description="Anti-hipertensivos"},
                new FirstSubGroupList{ID=25,GroupID=13,Description="Hipolipemiantes"},
                new FirstSubGroupList{ID=26,GroupID=14,Description="Antianêmicos"},
                new FirstSubGroupList{ID=27,GroupID=14,Description="Anticoagulantes e antagonista"},
                new FirstSubGroupList{ID=28,GroupID=14,Description="Antiagregante plaquetário"},
                new FirstSubGroupList{ID=29,GroupID=15,Description="Antiácidos"},
                new FirstSubGroupList{ID=30,GroupID=15,Description="Antissecretores"},
                new FirstSubGroupList{ID=31,GroupID=15,Description="Antimicrobianos (erradicação de Helicobter pylori"},
                new FirstSubGroupList{ID=32,GroupID=15,Description="Antieméticos e agente procinético"},
                new FirstSubGroupList{ID=33,GroupID=15,Description="Antiespasmódicos e antidiarreico sintomático"},
                new FirstSubGroupList{ID=34,GroupID=15,Description="Laxativos"},
                new FirstSubGroupList{ID=35,GroupID=16,Description="Antiasmáticos e fármaco para alívio dos sintomas da rinite"},
                new FirstSubGroupList{ID=36,GroupID=17,Description="Hormônio tireoidiano, medicamentos antitireoidianos e adjuvante"},
                new FirstSubGroupList{ID=38,GroupID=17,Description="Insulinas e hipoglicemiantes orais"},
                new FirstSubGroupList{ID=39,GroupID=17,Description="Hormônios sexuais, antagonistas e medicamentos relacionados"},
                new FirstSubGroupList{ID=40,GroupID=20,Description="Anestésico local"},
                new FirstSubGroupList{ID=41,GroupID=20,Description="Anti-infectantes"},
                new FirstSubGroupList{ID=42,GroupID=20,Description="Antipruriginosos e anti-inflamatórios"},
                new FirstSubGroupList{ID=43,GroupID=20,Description="Escabicida e pediculicida"}
            };
        }
    }
}
