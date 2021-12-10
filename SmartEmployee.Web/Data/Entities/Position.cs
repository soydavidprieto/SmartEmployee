using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SmartEmployee.Web.Data.Entities
{
    public class Position
    {
        [Key]
        public int positionId { get; set; }
        [Required]
        [Display(Name ="Position Name")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string positionDescription { get; set; }

        public ICollection<LaboralInfo> LaboralInfos { get; set; }
    }
}
