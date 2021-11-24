using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace SmartEmployee.Web.Data.Entities
{
    public class Company
    {
        [Key]
        public int companyId { get; set; }

        [Required]
        [Display(Name ="Name of Company")]
        [MaxLength(150, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string companyName { get; set; }

        [Required]
        [Display(Name ="Legal Number")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string companyNit { get; set; }

        
        public PayrollType PayrollType { get; set; }

        public ICollection<User> users { get; set; } 
        public ICollection<Office> offices { get; set; }
        public ICollection<LaboralInfo> laboralInfos { get; set; }
    }
}
