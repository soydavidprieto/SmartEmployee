using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SmartEmployee.Web.Data.Entities
{
    public class Office
    {
        [Key]
        public int officeId { get; set; }

        [Display(Name = "Office name")]
        [Required]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string officeName { get; set; }

        [Display (Name ="Address")]
        [Required]
        [MaxLength (100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string officeAddress { get; set; }

        [Display(Name ="Phone Number")]
        [Required]
        [MaxLength (20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string officePhoneNumber { get; set; }

        public Company Company { get; set; }
        public ICollection<LaboralInfo> laboralInfos { get; set; }



    }
}
