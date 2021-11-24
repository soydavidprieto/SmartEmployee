using System;
using System.ComponentModel.DataAnnotations;
namespace SmartEmployee.Web.Data.Entities
{
    public class LaboralInfo
    {
        [Key]
        public int laboralIfoId { get; set; }

        public Employee Employee { get; set; }

        public Company Company { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime employeeIncome { get; set; }

        [Required]
        public Position Position { get; set; }

        [Required]
        public Office Office { get; set; }

        [Required]
        public Eps Eps { get; set; }

        [Required]
        public Arl Arl { get; set; }

        [Required]
        public Afp Afp { get; set; }

        [Required]
        public Ccf Ccf { get; set; }

        [Required]
        public Schedule Schedule { get; set; }

        [Required]
        [Display(Name ="Salary")]
        public decimal employeeSalary { get; set; }
    }
}
