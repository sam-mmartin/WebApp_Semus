using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApp_Semus.Models.List
{
    public class SubGroupViewModel : Base
    {
        [HiddenInput]
        public int GroupID { get; set; }
        [Display(Name = "Grupo")]
        public int ForeignKey { get; set; }
    }
}
