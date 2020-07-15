using System.Collections.Generic;

namespace WebApp_Semus.Lists
{
    public class SecondSubGroup
    {
        public string ID { get; set; }
        public string Description { get; set; }

        public static List<SecondSubGroup> ListSecondSubGroup()
        {
            return new List<SecondSubGroup>
            {
                new SecondSubGroup{ID="6.1.1", Description="Penicilinas"},
                new SecondSubGroup{ID="6.1.2", Description="Cefalosporinas"},
                new SecondSubGroup{ID="6.1.3", Description="Sulfonamídeos"},
                new SecondSubGroup{ID="6.1.4", Description="Macrolídeos"},
                new SecondSubGroup{ID="6.1.5", Description="Fluorquinolonas"},
                new SecondSubGroup{ID="6.1.6", Description="Lincosamida"},
                new SecondSubGroup{ID="6.1.7", Description="Imidazólicos"},
                new SecondSubGroup{ID="6.1.8", Description="Anfenicol"},
                new SecondSubGroup{ID="6.2.1", Description="Medicamentos para o tratamento de tracoma"},
                new SecondSubGroup{ID="6.3.1", Description="Antifúngicos sistêmicos"},
                new SecondSubGroup{ID="6.3.2", Description="Antifúngicos tópicos"},
                new SecondSubGroup{ID="6.3.3", Description="Antimicrobianos e outros medicamentos para o tratamento da pneumocistose"},
                new SecondSubGroup{ID="6.4.1", Description="Inibidores da polimerase viral"},
                new SecondSubGroup{ID="6.5.1", Description="Anti-helmínticos"},
                new SecondSubGroup{ID="6.5.2", Description="Antiprotozoários"},
                new SecondSubGroup{ID="13.4.1", Description="Diuréticos"},
                new SecondSubGroup{ID="13.4.2", Description="Bloqueadores adrenérgicos"},
                new SecondSubGroup{ID="13.4.3", Description="Bloqueadores de canal de cálcio"},
                new SecondSubGroup{ID="13.4.4", Description="Inibidores da enzima conversora da angiotensina"},
                new SecondSubGroup{ID="13.4.5", Description="Bloqueador de receptor da angiotensina"},
                new SecondSubGroup{ID="13.4.6", Description="Vasodilatador direto"},
                new SecondSubGroup{ID="13.4.7", Description="Diuréticos"},
                new SecondSubGroup{ID="17.3.1", Description="Progestógeno"},
                new SecondSubGroup{ID="17.3.2", Description="Contraceptivos hormonais orais"},
                new SecondSubGroup{ID="17.3.3", Description="Contraceptivos hormonais injetáveis"},
                new SecondSubGroup{ID="17.3.4", Description="Medicamentos que atuam na contratilidade uterina"},
            };
        }
    }
}
