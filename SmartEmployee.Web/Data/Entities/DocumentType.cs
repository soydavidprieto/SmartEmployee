using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SmartEmployee.Web.Data.Entities
{
    public class DocumentType
    {
        [Key]
        public int documentTypeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string documentTypeDescription { get; set; }

        public ICollection<Employee> Employees { get; set; }


    }
}
