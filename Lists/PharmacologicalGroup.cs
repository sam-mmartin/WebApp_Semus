using System.Collections.Generic;

namespace WebApp_Semus.Lists
{
    public class PharmacologicalGroup
    {
        public string Description { get; set; }

        public List<PharmacologicalGroup> ListPharmacologicalGroup()
        {
            return new List<PharmacologicalGroup>
            {
                new PharmacologicalGroup{Description="ANESTÉSICOS E ADJUVANTES"},
                new PharmacologicalGroup{Description="ANALGÉSICOS, ANTIPIRÉTICOS E MEDICAMENTOS PARA O ALÍVEIO DA ENXAQUECA"},
                new PharmacologicalGroup{Description="MEDICAMENTOS PARA ALÍVIO DA DOR CRÔNICA"},
                new PharmacologicalGroup{Description="ANTI-INFLAMATÓRIOS E MEDICAMENTOS PARA O TRATAMENTO DA GOTA"},
                new PharmacologicalGroup{Description="ANTIALÉRGICOS E MEDICAMENTOS USADOS EM ANAFILAXIA"},
                new PharmacologicalGroup{Description="ANTI-INFECTANTES"},
                new PharmacologicalGroup{Description="IMUNOSSUPRESSORES E IMUNOTERÁPICOS"},
                new PharmacologicalGroup{Description="MEDICAMENTOS E ANTÍDOTOS USADOS EM INTOXICAÇÕES EXÓGENAS"},
                new PharmacologicalGroup{Description="SOLUÇÕES HIDROELETROLÍTICAS E CORRETORAS DO EQUILÍBRIO ÁCIDO-BÁSICO"},
                new PharmacologicalGroup{Description="AGENTES EMPREGADOS NA TERAPÊUTICA DE NUTRIÇÃO"},
                new PharmacologicalGroup{Description="VITAMINAS E SUBSTÂNCIAS MINERAIS"},
                new PharmacologicalGroup{Description="MEDICAMENTOS QUE ATUAM SOBRE O SISTEMA NERVOSO CENTRAL E PERIFÉRICO"},
                new PharmacologicalGroup{Description="MEDICAMENTOS QUE ATUAM SOBRE O SISTEMA CARDIOVASCULAR E RENAL"},
                new PharmacologicalGroup{Description="MEDICAMENTOS QUE ATUAM SOBRE O SANGUE"},
                new PharmacologicalGroup{Description="MEDICAMENTOS QUE ATUAM SOBRE O SISTEMA DIGESTIVO"},
                new PharmacologicalGroup{Description="MEDICAMENTOS QUE ATUAM SOBRE O SISTEMA RESPIRATÓRIO"},
                new PharmacologicalGroup{Description="MEDICAMENTOS QUE ATUAM SOBRE OS SISTEMAS ENDÓCRINO, REPRODUTOR E URINÁRIO"},
                new PharmacologicalGroup{Description="MEDICAMENTOS UTILIZADOS NO TRATAMENTO/PREVENÇÃO DA OSTEOPOROSE"},
                new PharmacologicalGroup{Description="MEDICAMENTO UTILIZADO NO TRATAMENTO DA DOENÇA DE PAGET"},
                new PharmacologicalGroup{Description="FÁRMACOS USADOS EM PELE, MUCOSAS E FÂNEROS"},
                new PharmacologicalGroup{Description="FÁRMACO UTILIZADO NO TRATAMENTO NA HIPERPLASIA BENIGNA DA PRÓSTATA"},
                new PharmacologicalGroup{Description="RELAÇÃO DE INSUMOS"},
                new PharmacologicalGroup{Description="RELAÇÃO DE MEDICAMENTOS DE USO HOSPITALAR"}
            };
        }
    }
}
