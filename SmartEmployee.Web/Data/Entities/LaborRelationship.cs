using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace SmartEmployee.Web.Data.Entities
{
    public class LaborRelationship
    {
        [Key]
        public int relationshipId { get; set; }

        [Display(Name = "Name of labor Relationship")]
        [Required]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string relationshipName { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
