using System.Collections.Generic;

namespace WebApp_Semus.Lists
{
    public class PharmacologicalGroup
    {
        public int ID { get; set; }
        public string Description { get; set; }

        public List<PharmacologicalGroup> ListPharmacologicalGroup()
        {
            return new List<PharmacologicalGroup>
            {
                new PharmacologicalGroup{ID=1,Description="ANESTÉSICOS E ADJUVANTES"},
                new PharmacologicalGroup{ID=1,Description="ANALGÉSICOS, ANTIPIRÉTICOS E MEDICAMENTOS PARA O ALÍVEIO DA ENXAQUECA"},
                new PharmacologicalGroup{ID=1,Description="MEDICAMENTOS PARA ALÍVIO DA DOR CRÔNICA"},
                new PharmacologicalGroup{ID=1,Description="ANTI-INFLAMATÓRIOS E MEDICAMENTOS PARA O TRATAMENTO DA GOTA"},
                new PharmacologicalGroup{ID=1,Description="ANTIALÉRGICOS E MEDICAMENTOS USADOS EM ANAFILAXIA"},
                new PharmacologicalGroup{ID=1,Description="ANTI-INFECTANTES"},
                new PharmacologicalGroup{ID=1,Description="IMUNOSSUPRESSORES E IMUNOTERÁPICOS"},
                new PharmacologicalGroup{ID=1,Description="MEDICAMENTOS E ANTÍDOTOS USADOS EM INTOXICAÇÕES EXÓGENAS"},
                new PharmacologicalGroup{ID=1,Description="SOLUÇÕES HIDROELETROLÍTICAS E CORRETORAS DO EQUILÍBRIO ÁCIDO-BÁSICO"},
                new PharmacologicalGroup{ID=1,Description="AGENTES EMPREGADOS NA TERAPÊUTICA DE NUTRIÇÃO"},
                new PharmacologicalGroup{ID=1,Description="VITAMINAS E SUBSTÂNCIAS MINERAIS"},
                new PharmacologicalGroup{ID=2,Description="MEDICAMENTOS QUE ATUAM SOBRE O SISTEMA NERVOSO CENTRAL E PERIFÉRICO"},
                new PharmacologicalGroup{ID=2,Description="MEDICAMENTOS QUE ATUAM SOBRE O SISTEMA CARDIOVASCULAR E RENAL"},
                new PharmacologicalGroup{ID=2,Description="MEDICAMENTOS QUE ATUAM SOBRE O SANGUE"},
                new PharmacologicalGroup{ID=2,Description="MEDICAMENTOS QUE ATUAM SOBRE O SISTEMA DIGESTIVO"},
                new PharmacologicalGroup{ID=2,Description="MEDICAMENTOS QUE ATUAM SOBRE O SISTEMA RESPIRATÓRIO"},
                new PharmacologicalGroup{ID=2,Description="MEDICAMENTOS QUE ATUAM SOBRE OS SISTEMAS ENDÓCRINO, REPRODUTOR E URINÁRIO"},
                new PharmacologicalGroup{ID=2,Description="MEDICAMENTOS UTILIZADOS NO TRATAMENTO/PREVENÇÃO DA OSTEOPOROSE"},
                new PharmacologicalGroup{ID=2,Description="MEDICAMENTO UTILIZADO NO TRATAMENTO DA DOENÇA DE PAGET"},
                new PharmacologicalGroup{ID=2,Description="FÁRMACOS USADOS EM PELE, MUCOSAS E FÂNEROS"},
                new PharmacologicalGroup{ID=2,Description="FÁRMACO UTILIZADO NO TRATAMENTO NA HIPERPLASIA BENIGNA DA PRÓSTATA"},
                new PharmacologicalGroup{ID=2,Description="RELAÇÃO DE INSUMOS"},
                new PharmacologicalGroup{ID=2,Description="RELAÇÃO DE MEDICAMENTOS DE USO HOSPITALAR"}
            };
        }
    }
}
