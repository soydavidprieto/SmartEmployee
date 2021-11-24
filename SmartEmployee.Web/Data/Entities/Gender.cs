using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace SmartEmployee.Web.Data.Entities
{
    public class Gender
    {
        [Key]
        public int genderId{ get; set; }

        [Required]
        [MaxLength(50)]
        public string genderDescription { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
