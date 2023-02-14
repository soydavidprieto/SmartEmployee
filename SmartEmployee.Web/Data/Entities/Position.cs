using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SmartEmployee.Web.Data.Entities
{
    public class Position
    {
        [Key]
        public int positionId { get; set; }
        [Required]
        [Display(Name ="Name of Position")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string positionName { get; set; }
        
        [Display(Name = "Description")]
        [MaxLength(800, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string positionDescription { get; set; } 
        
        [Display (Name = "General functions")]
        [MaxLength(800, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string generalFunctions { get; set; }

        [Display(Name="Specific functions")]
        [MaxLength(800, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string specificFunctions { get; set; }

        public ICollection<LaboralInfo> LaboralInfos { get; set; }
    }
}
