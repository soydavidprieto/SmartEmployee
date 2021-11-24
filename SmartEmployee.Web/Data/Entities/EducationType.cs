using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SmartEmployee.Web.Data.Entities
{
    public class EducationType
    {
        [Key]
        public int educationTypeId { get; set; }

        [Required]
        [Display(Name ="Name")]
        [StringLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string educationTypeName { get; set; }

        public ICollection<EducationInfo> EducationInfos { get; set; }


    }
}
