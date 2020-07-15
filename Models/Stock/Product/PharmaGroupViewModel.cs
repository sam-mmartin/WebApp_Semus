using System.ComponentModel.DataAnnotations;

namespace WebApp_Semus.Models.Stock.Product
{
    public class PharmaGroupViewModel
    {
        // Key
        [Required, Display(Name = "Código")]
        public int ID { get; set; }

        // Atributes
        [Required]
        [StringLength(100)]
        [Display(Name = "Descrição")]
        public string Name { get; set; }

        [Display(Name = "Seção")]
        public string Section { get; set; }

        [Display(Name = "Seção - descrição")]
        public string SectionName { get; set; }

        public string FirstSubGroup { get; set; }
        public string SecondSubGroup { get; set; }
        public string ThirdSubGroup { get; set; }

        public string FirstGroupName { get; set; }
        public string SecondGroupName { get; set; }
        public string ThirdGroupName { get; set; }
    }
}
