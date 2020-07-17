using System.Collections.Generic;

namespace WebApp_Semus.Lists
{
    public class SecondSubGroupList
    {
        public int ID { get; set; }
        public int FirstID { get; set; }
        public string Description { get; set; }

        public List<SecondSubGroupList> ListSecondSubGroup()
        {
            return new List<SecondSubGroupList>
            {
                new SecondSubGroupList{ID=1,FirstID=8,Description="Penicilinas"},
                new SecondSubGroupList{ID=2,FirstID=8,Description="Cefalosporinas"},
                new SecondSubGroupList{ID=3,FirstID=8,Description="Sulfonamídeos"},
                new SecondSubGroupList{ID=4,FirstID=8,Description="Macrolídeos"},
                new SecondSubGroupList{ID=5,FirstID=8,Description="Fluorquinolonas"},
                new SecondSubGroupList{ID=6,FirstID=8,Description="Lincosamida"},
                new SecondSubGroupList{ID=7,FirstID=8,Description="Imidazólicos"},
                new SecondSubGroupList{ID=8,FirstID=8,Description="Anfenicol"},
                new SecondSubGroupList{ID=9,FirstID=9,Description="Medicamentos para o tratamento de tracoma"},
                new SecondSubGroupList{ID=10,FirstID=10,Description="Antifúngicos sistêmicos"},
                new SecondSubGroupList{ID=11,FirstID=10,Description="Antifúngicos tópicos"},
                new SecondSubGroupList{ID=12,FirstID=10,Description="Antimicrobianos e outros medicamentos para o tratamento da pneumocistose"},
                new SecondSubGroupList{ID=13,FirstID=11,Description="Inibidores da polimerase viral"},
                new SecondSubGroupList{ID=14,FirstID=12,Description="Anti-helmínticos"},
                new SecondSubGroupList{ID=15,FirstID=12,Description="Antiprotozoários"},
                new SecondSubGroupList{ID=16,FirstID=24,Description="Diuréticos"},
                new SecondSubGroupList{ID=17,FirstID=24,Description="Bloqueadores adrenérgicos"},
                new SecondSubGroupList{ID=18,FirstID=24,Description="Bloqueadores de canal de cálcio"},
                new SecondSubGroupList{ID=19,FirstID=24,Description="Inibidores da enzima conversora da angiotensina"},
                new SecondSubGroupList{ID=20,FirstID=24,Description="Bloqueador de receptor da angiotensina"},
                new SecondSubGroupList{ID=21,FirstID=24,Description="Vasodilatador direto"},
                new SecondSubGroupList{ID=22,FirstID=24,Description="Diuréticos"},
                new SecondSubGroupList{ID=23,FirstID=39,Description="Progestógeno"},
                new SecondSubGroupList{ID=24,FirstID=39,Description="Contraceptivos hormonais orais"},
                new SecondSubGroupList{ID=25,FirstID=39,Description="Contraceptivos hormonais injetáveis"},
                new SecondSubGroupList{ID=26,FirstID=39,Description="Medicamentos que atuam na contratilidade uterina"},
            };
        }
    }
}
