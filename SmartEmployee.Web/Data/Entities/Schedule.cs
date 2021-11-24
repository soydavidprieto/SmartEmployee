using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SmartEmployee.Web.Data.Entities
{
    public class Schedule
    {
        [Key]
        public int scheduleId { get; set; }

        [Required]
        [Display(Name = "Name")]
        [MaxLength(150, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string scheduleName { get; set; }

        [Required]
        [Display(Name = "Working hours")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string workingHours { get; set; }

        [Required]
        [Display(Name ="Break")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string scheduleBreak { get; set; }

        public ICollection<LaboralInfo> laboralInfos { get; set; }
    }
}
