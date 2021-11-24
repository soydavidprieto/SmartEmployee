using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartEmployee.Web.Data.Entities
{
    public class Arl
    {
        [Key]
        public int arlId { get; set; }

        [Required]
        [Display(Name = "Name of ARL")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string arlName { get; set; }

        [Required]
        [Display(Name ="Nit of ARL")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string arlNit { get; set; }

        public ICollection<LaboralInfo> LaboralInfos { get; set; }
    }
}
