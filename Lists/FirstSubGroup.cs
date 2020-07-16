using System.Collections.Generic;

namespace WebApp_Semus.Lists
{
    public class FirstSubGroup
    {
        public string Description { get; set; }

        public List<FirstSubGroup> ListFirstSubGroup()
        {
            return new List<FirstSubGroup>
            {
                new FirstSubGroup{Description="Medicamentos Adjuvantes usados em procedimentos anestésicos de curta duração"},
                new FirstSubGroup{Description="Anestésicos locais"},
                new FirstSubGroup{Description="Analgésicos e antipiréticos"},
                new FirstSubGroup{Description="Medicamentos para alívio da enxaqueca"},
                new FirstSubGroup{Description="Anti-inflamatórios não-esteroides"},
                new FirstSubGroup{Description="Anti-infamatórios esteroides"},
                new FirstSubGroup{Description="Medicamentos para o tratamento da gota"},
                new FirstSubGroup{Description="Antibacterianos"},
                new FirstSubGroup{Description="Medicamentos para tratamento de endemias focais"},
                new FirstSubGroup{Description="Antifúngicos"},
                new FirstSubGroup{Description="Antivirais"},
                new FirstSubGroup{Description="Antiparasitários"},
                new FirstSubGroup{Description="Antissépticos, desinfetantes e esterilizantes"},
                new FirstSubGroup{Description="Imunossupressores"},
                new FirstSubGroup{Description="Não-específicos"},
                new FirstSubGroup{Description="Específicos"},
                new FirstSubGroup{Description="Anticonculsivantes"},
                new FirstSubGroup{Description="Antidepressivos e estabilizadores de humor"},
                new FirstSubGroup{Description="Antipsicóticos e adjuvantes"},
                new FirstSubGroup{Description="Ansiolíticos e hipnossedativos"},
                new FirstSubGroup{Description="Medicamentos utilizados na insuficiência cardíaca e choque cardiovascular"},
                new FirstSubGroup{Description="Medicamentos antiarrítmicos"},
                new FirstSubGroup{Description="Medicamentos usados em cardiopatia isquêmica"},
                new FirstSubGroup{Description="Anti-hipertensivos"},
                new FirstSubGroup{Description="Hipolipemiantes"},
                new FirstSubGroup{Description="Antianêmicos"},
                new FirstSubGroup{Description="Anticoagulantes e antagonista"},
                new FirstSubGroup{Description="Antiagregante plaquetário"},
                new FirstSubGroup{Description="Antiácidos"},
                new FirstSubGroup{Description="Antissecretores"},
                new FirstSubGroup{Description="Antimicrobianos (erradicação de Helicobter pylori"},
                new FirstSubGroup{Description="Antieméticos e agente procinético"},
                new FirstSubGroup{Description="Antiespasmódicos e antidiarreico sintomático"},
                new FirstSubGroup{Description="Laxativos"},
                new FirstSubGroup{Description="Antiasmáticos e fármaco para alívio dos sintomas da rinite"},
                new FirstSubGroup{Description="Hormônio tireoidiano, medicamentos antitireoidianos e adjuvante"},
                new FirstSubGroup{Description="Insulinas e hipoglicemiantes orais"},
                new FirstSubGroup{Description="Hormônios sexuais, antagonistas e medicamentos relacionados"},
                new FirstSubGroup{Description="Anestésico local"},
                new FirstSubGroup{Description="Anti-infectantes"},
                new FirstSubGroup{Description="Antipruriginosos e anti-inflamatórios"},
                new FirstSubGroup{Description="Escabicida e pediculicida"}
            };
        }
    }
}
