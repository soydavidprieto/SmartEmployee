using System;
using System.ComponentModel.DataAnnotations;
namespace SmartEmployee.Web.Data.Entities
{
    public class EducationInfo
    {
        [Key]
        public int EducationId { get; set; }

        [Required]
        public Employee Employee { get; set; }
        [Required]
        public EducationType EducationType { get; set; }

        [Required]
        [Display(Name ="Degree")]
        [MaxLength(200, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string degree { get; set; }

        [Required]
        [Display (Name="Institution")]
        [MaxLength(150, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string institution { get; set; }

        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime startDate { get; set; }

        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime endDate { get; set; }

    }
}
