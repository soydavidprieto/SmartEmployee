using System;
using System.ComponentModel.DataAnnotations;
namespace SmartEmployee.Web.Data.Entities
{
    public class Contract
    {
        [Key]
        public int contractId { get; set; }
   
        [Required]
        public Employee Employee { get; set; }  
        public LaborRelationship LaborRelationship { get; set; }

        [Display(Name ="Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime startDate { get; set; }

        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime endDate { get; set; }
    }
}

