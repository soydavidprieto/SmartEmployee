using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartEmployee.Web.Data.Entities
{
    public class Ccf
    {
        [Key]
        public int ccfId { get; set; }

        [Required]
        [Display(Name = "Name of CCF")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string ccfName { get; set; }

        [Required]
        [Display(Name = "Nit of CCF")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string ccfNit { get; set; }

        public ICollection<LaboralInfo> LaboralInfos { get; set; }
    }
}