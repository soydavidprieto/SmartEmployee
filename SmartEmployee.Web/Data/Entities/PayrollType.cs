using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SmartEmployee.Web.Data.Entities
{
    public class PayrollType
    {
        [Key]
        public int payrollTypeId { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name="Type")]
        [MaxLength(150, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string payrollTypeDescription { get; set; }

        public ICollection <Company> companies { get; set; }
    }
}
