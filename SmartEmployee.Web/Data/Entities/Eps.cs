using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SmartEmployee.Web.Data.Entities
{
    public class Eps
    {
        [Key]
        public int epsId { get; set; }

        [Required]
        [Display(Name ="Name of EPS")]
        [MaxLength(100, ErrorMessage ="The {0} field can not have more than {1} characters.")]
        public string epsName { get; set; }

        [Required]
        [Display(Name ="Nit of EPS")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string epsNit { get; set; }

        public ICollection<LaboralInfo> LaboralInfos { get; set; }
    }
}
