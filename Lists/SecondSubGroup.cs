using System.Collections.Generic;

namespace WebApp_Semus.Lists
{
    public class SecondSubGroup
    {
        public string Description { get; set; }

        public List<SecondSubGroup> ListSecondSubGroup()
        {
            return new List<SecondSubGroup>
            {
                new SecondSubGroup{Description="Penicilinas"},
                new SecondSubGroup{Description="Cefalosporinas"},
                new SecondSubGroup{Description="Sulfonamídeos"},
                new SecondSubGroup{Description="Macrolídeos"},
                new SecondSubGroup{Description="Fluorquinolonas"},
                new SecondSubGroup{Description="Lincosamida"},
                new SecondSubGroup{Description="Imidazólicos"},
                new SecondSubGroup{Description="Anfenicol"},
                new SecondSubGroup{Description="Medicamentos para o tratamento de tracoma"},
                new SecondSubGroup{Description="Antifúngicos sistêmicos"},
                new SecondSubGroup{Description="Antifúngicos tópicos"},
                new SecondSubGroup{Description="Antimicrobianos e outros medicamentos para o tratamento da pneumocistose"},
                new SecondSubGroup{Description="Inibidores da polimerase viral"},
                new SecondSubGroup{Description="Anti-helmínticos"},
                new SecondSubGroup{Description="Antiprotozoários"},
                new SecondSubGroup{Description="Diuréticos"},
                new SecondSubGroup{Description="Bloqueadores adrenérgicos"},
                new SecondSubGroup{Description="Bloqueadores de canal de cálcio"},
                new SecondSubGroup{Description="Inibidores da enzima conversora da angiotensina"},
                new SecondSubGroup{Description="Bloqueador de receptor da angiotensina"},
                new SecondSubGroup{Description="Vasodilatador direto"},
                new SecondSubGroup{Description="Diuréticos"},
                new SecondSubGroup{Description="Progestógeno"},
                new SecondSubGroup{Description="Contraceptivos hormonais orais"},
                new SecondSubGroup{Description="Contraceptivos hormonais injetáveis"},
                new SecondSubGroup{Description="Medicamentos que atuam na contratilidade uterina"},
            };
        }
    }
}
