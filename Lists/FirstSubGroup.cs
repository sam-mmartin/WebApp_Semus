using System.Collections.Generic;

namespace WebApp_Semus.Lists
{
    public class FirstSubGroup
    {
        public string ID { get; set; }
        public string Description { get; set; }

        public static List<FirstSubGroup> ListFirstSubGroup()
        {
            return new List<FirstSubGroup>
            {
                new FirstSubGroup{ID="1.1", Description="Medicamentos Adjuvantes usados em procedimentos anestésicos de curta duração"},
                new FirstSubGroup{ID="1.2", Description="Anestésicos locais"},
                new FirstSubGroup{ID="2.1", Description="Analgésicos e antipiréticos"},
                new FirstSubGroup{ID="2.2", Description="Medicamentos para alívio da enxaqueca"},
                new FirstSubGroup{ID="4.1", Description="Anti-inflamatórios não-esteroides"},
                new FirstSubGroup{ID="4.2", Description="Anti-infamatórios esteroides"},
                new FirstSubGroup{ID="4.3", Description="Medicamentos para o tratamento da gota"},
                new FirstSubGroup{ID="6.1", Description="Antibacterianos"},
                new FirstSubGroup{ID="6.2", Description="Medicamentos para tratamento de endemias focais"},
                new FirstSubGroup{ID="6.3", Description="Antifúngicos"},
                new FirstSubGroup{ID="6.4", Description="Antivirais"},
                new FirstSubGroup{ID="6.5", Description="Antiparasitários"},
                new FirstSubGroup{ID="6.6", Description="Antissépticos, desinfetantes e esterilizantes"},
                new FirstSubGroup{ID="7.1", Description="Imunossupressores"},
                new FirstSubGroup{ID="8.1", Description="Não-específicos"},
                new FirstSubGroup{ID="8.2", Description="Específicos"},
                new FirstSubGroup{ID="12.1", Description="Anticonculsivantes"},
                new FirstSubGroup{ID="12.2", Description="Antidepressivos e estabilizadores de humor"},
                new FirstSubGroup{ID="12.3", Description="Antipsicóticos e adjuvantes"},
                new FirstSubGroup{ID="12.4", Description="Ansiolíticos e hipnossedativos"},
                new FirstSubGroup{ID="13.1", Description="Medicamentos utilizados na insuficiência cardíaca e choque cardiovascular"},
                new FirstSubGroup{ID="13.2", Description="Medicamentos antiarrítmicos"},
                new FirstSubGroup{ID="13.3", Description="Medicamentos usados em cardiopatia isquêmica"},
                new FirstSubGroup{ID="13.4", Description="Anti-hipertensivos"},
                new FirstSubGroup{ID="13.5", Description="Hipolipemiantes"},
                new FirstSubGroup{ID="14.1", Description="Antianêmicos"},
                new FirstSubGroup{ID="14.2", Description="Anticoagulantes e antagonista"},
                new FirstSubGroup{ID="14.3", Description="Antiagregante plaquetário"},
                new FirstSubGroup{ID="15.1", Description="Antiácidos"},
                new FirstSubGroup{ID="15.2", Description="Antissecretores"},
                new FirstSubGroup{ID="15.3", Description="Antimicrobianos (erradicação de Helicobter pylori"},
                new FirstSubGroup{ID="15.4", Description="Antieméticos e agente procinético"},
                new FirstSubGroup{ID="15.5", Description="Antiespasmódicos e antidiarreico sintomático"},
                new FirstSubGroup{ID="15.6", Description="Laxativos"},
                new FirstSubGroup{ID="16.1", Description="Antiasmáticos e fármaco para alívio dos sintomas da rinite"},
                new FirstSubGroup{ID="17.1", Description="Hormônio tireoidiano, medicamentos antitireoidianos e adjuvante"},
                new FirstSubGroup{ID="17.2", Description="Insulinas e hipoglicemiantes orais"},
                new FirstSubGroup{ID="17.3", Description="Hormônios sexuais, antagonistas e medicamentos relacionados"},
                new FirstSubGroup{ID="20.1", Description="Anestésico local"},
                new FirstSubGroup{ID="20.2", Description="Anti-infectantes"},
                new FirstSubGroup{ID="20.3", Description="Antipruriginosos e anti-inflamatórios"},
                new FirstSubGroup{ID="20.4", Description="Escabicida e pediculicida"}
            };
        }
    }
}
