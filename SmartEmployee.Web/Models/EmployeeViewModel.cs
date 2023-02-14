using Microsoft.AspNetCore.Mvc.Rendering;
using SmartEmployee.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartEmployee.Web.Models
{
    public class EmployeeViewModel
    {
        [Required]
        [Display(Name = "Firt name")]
        [MaxLength(150, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string firstName { get; set; }

        [Required]
        [Display(Name = "Surname")]
        [MaxLength(80, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string surname { get; set; }

        [Required]
        [Display(Name = "Second surname")]
        [MaxLength(80, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string secondSurname { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [EmailAddress]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The {0} field must contain between {2} and {1} characters.")]
        public string Password { get; set; }

        [Display(Name = "Password Confirm")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The {0} field must contain between {2} and {1} characters.")]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }
        
               
        //public int emmployeeId { get; set; }



        //[Display(Name = "Document")]
        //[MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        //public string employeeDocument { get; set; }

        
        //[Display(Name = "Genger")]
        //public int genderId { get; set; }

        //public IEnumerable<SelectListItem> Genders { get; set; }

       
        //[Display(Name = "Document type")]
        //public int documentTypeId { get; set; }

        //public IEnumerable<SelectListItem> DocumentTypes { get; set; }


        //[Display(Name = "Date of birth")]
        //[Required(ErrorMessage = "The field {0} is mandatory.")]
        //[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        //public DateTime employeeBirth { get; set; }

        //[Display(Name = "Fixed Phone")]
        //[MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        //public string employeeFixedPhone { get; set; }


        //[Display(Name = "Cell Phone")]
        //[Required]
        //[MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        //public string employeeCellPhone { get; set; }

        //[Display(Name = "Address")]
        //[Required]
        //[MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        //public string employeeAddress { get; set; }

        //public Employee Employee { get; set; }

        //public IEnumerable<SelectListItem> Companies { get; set; }

        //[Display(Name ="Company")]
        //public int companyId { get; set; }

        //[Required]
        //[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]

        //[Display(Name ="In come")]
        //public DateTime employeeIncome { get; set; }

        //public IEnumerable<SelectListItem> Positions { get; set; }

        //[Display(Name ="Position")]
        //public int positionId { get; set; }

        
        
        //public IEnumerable<SelectListItem> Offices { get; set; }

        //[Display(Name = "Office")]
        //public int officeId { get; set; }

        
        //public IEnumerable<SelectListItem> Eps { get; set; }

        //[Display(Name = "Eps")]
        //public int epsId { get; set; }

        
        //public IEnumerable<SelectListItem> Arl { get; set; }

        //[Display(Name = "Arl")]
        //public int arlId { get; set; }

        
        //public IEnumerable<SelectListItem> Afp { get; set; }

        //[Display(Name = "Afp")]
        //public int afpId { get; set; }

        //public IEnumerable<SelectListItem> Ccf { get; set; }

        //[Display(Name = "Ccf")]

        //public int ccfId { get; set; }

        
        //public IEnumerable<SelectListItem> Schedule { get; set; }

        //[Display(Name = "Schedule")]
        //public int scheduleId { get; set; }

        //[Required]
        //[Display(Name = "Salary")]
        //public decimal employeeSalary { get; set; }

        
        
        //public IEnumerable<SelectListItem> EducationType { get; set; }

        //[Display(Name = "Education Type")]
        //public int educationTypeId { get; set; }

        //[Required]
        //[Display(Name = "Degree")]
        //[MaxLength(200, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        //public string degree { get; set; }

        //[Required]
        //[Display(Name = "Institution")]
        //[MaxLength(150, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        //public string institution { get; set; }

        //[Display(Name = "Start Date")]
        //[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        //public DateTime startDate { get; set; }

        //[Display(Name = "End Date")]
        //[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        //public DateTime endDate { get; set; }
    }
}
