using System.Collections.Generic;

namespace WebApp_Semus.Lists
{
    public class PharmacologicalGroupList
    {
        public int ID { get; set; }
        public int ForeignKey { get; set; }
        public string Description { get; set; }

        public List<PharmacologicalGroupList> ListPharmacologicalGroup()
        {
            return new List<PharmacologicalGroupList>
            {
                new PharmacologicalGroupList{ID=1,ForeignKey=1,Description="ANESTÉSICOS E ADJUVANTES"},
                new PharmacologicalGroupList{ID=2,ForeignKey=1,Description="ANALGÉSICOS, ANTIPIRÉTICOS E MEDICAMENTOS PARA O ALÍVEIO DA ENXAQUECA"},
                new PharmacologicalGroupList{ID=3,ForeignKey=1,Description="MEDICAMENTOS PARA ALÍVIO DA DOR CRÔNICA"},
                new PharmacologicalGroupList{ID=4,ForeignKey=1,Description="ANTI-INFLAMATÓRIOS E MEDICAMENTOS PARA O TRATAMENTO DA GOTA"},
                new PharmacologicalGroupList{ID=5,ForeignKey=1,Description="ANTIALÉRGICOS E MEDICAMENTOS USADOS EM ANAFILAXIA"},
                new PharmacologicalGroupList{ID=6,ForeignKey=1,Description="ANTI-INFECTANTES"},
                new PharmacologicalGroupList{ID=7,ForeignKey=1,Description="IMUNOSSUPRESSORES E IMUNOTERÁPICOS"},
                new PharmacologicalGroupList{ID=8,ForeignKey=1,Description="MEDICAMENTOS E ANTÍDOTOS USADOS EM INTOXICAÇÕES EXÓGENAS"},
                new PharmacologicalGroupList{ID=9,ForeignKey=1,Description="SOLUÇÕES HIDROELETROLÍTICAS E CORRETORAS DO EQUILÍBRIO ÁCIDO-BÁSICO"},
                new PharmacologicalGroupList{ID=10,ForeignKey=1,Description="AGENTES EMPREGADOS NA TERAPÊUTICA DE NUTRIÇÃO"},
                new PharmacologicalGroupList{ID=11,ForeignKey=1,Description="VITAMINAS E SUBSTÂNCIAS MINERAIS"},
                new PharmacologicalGroupList{ID=12,ForeignKey=2,Description="MEDICAMENTOS QUE ATUAM SOBRE O SISTEMA NERVOSO CENTRAL E PERIFÉRICO"},
                new PharmacologicalGroupList{ID=13,ForeignKey=2,Description="MEDICAMENTOS QUE ATUAM SOBRE O SISTEMA CARDIOVASCULAR E RENAL"},
                new PharmacologicalGroupList{ID=14,ForeignKey=2,Description="MEDICAMENTOS QUE ATUAM SOBRE O SANGUE"},
                new PharmacologicalGroupList{ID=15,ForeignKey=2,Description="MEDICAMENTOS QUE ATUAM SOBRE O SISTEMA DIGESTIVO"},
                new PharmacologicalGroupList{ID=16,ForeignKey=2,Description="MEDICAMENTOS QUE ATUAM SOBRE O SISTEMA RESPIRATÓRIO"},
                new PharmacologicalGroupList{ID=17,ForeignKey=2,Description="MEDICAMENTOS QUE ATUAM SOBRE OS SISTEMAS ENDÓCRINO, REPRODUTOR E URINÁRIO"},
                new PharmacologicalGroupList{ID=18,ForeignKey=2,Description="MEDICAMENTOS UTILIZADOS NO TRATAMENTO/PREVENÇÃO DA OSTEOPOROSE"},
                new PharmacologicalGroupList{ID=19,ForeignKey=2,Description="MEDICAMENTO UTILIZADO NO TRATAMENTO DA DOENÇA DE PAGET"},
                new PharmacologicalGroupList{ID=20,ForeignKey=2,Description="FÁRMACOS USADOS EM PELE, MUCOSAS E FÂNEROS"},
                new PharmacologicalGroupList{ID=21,ForeignKey=2,Description="FÁRMACO UTILIZADO NO TRATAMENTO NA HIPERPLASIA BENIGNA DA PRÓSTATA"},
                new PharmacologicalGroupList{ID=22,ForeignKey=2,Description="RELAÇÃO DE INSUMOS"},
                new PharmacologicalGroupList{ID=23,ForeignKey=2,Description="RELAÇÃO DE MEDICAMENTOS DE USO HOSPITALAR"}
            };
        }
    }
}
