using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace SmartEmployee.Web.Data.Entities
{
    public class Employee
    {
        [Key]
        public int EmmployeeId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        [MaxLength(150, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string employeeFirstName { get; set; }

        [Required]
        [Display(Name = "Surname")]
        [MaxLength(80, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string employeeSurname { get; set; }

        [Required]
        [Display(Name = "Second surname")]
        [MaxLength(80, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string employeeSecondSurname { get; set; }

        [Required]
        [Display(Name = "Document Type")]
        public DocumentType DocumentType { get; set; }

        [Required]
        [Display(Name = "Document")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string employeeDocument { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public Gender Gender { get; set; }

        [Display(Name = "Date of birth")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime employeeBirth { get; set; }

        [Display(Name = "Fixed Phone")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string employeeFixedPhone { get; set; }


        [Display(Name = "Cell Phone")]
        [Required]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string employeeCellPhone { get; set; }

        [Display(Name = "Address")]
        [Required]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string employeeAddress { get; set; }

        [Required]
        [Display(Name = "Email address")]
        [MaxLength(150)]
        [DataType(DataType.EmailAddress)]
        public string employeeEmail { get; set; }


        [Display(Name ="Employee")]
        public string FullName => $"{employeeFirstName} {employeeSurname} {employeeSecondSurname}";

        public ICollection<Contract> Contracts { get; set; }
        public ICollection<LaboralInfo> LaboralInfos { get;}
        public ICollection<EducationInfo> EducationInfos { get;}

    }
}