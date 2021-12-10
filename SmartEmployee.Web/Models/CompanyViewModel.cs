using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartEmployee.Web.Data.Entities;

namespace SmartEmployee.Web.Models
{
    public class CompanyViewModel : Company 
    {
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Payroll Type")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a pet type.")]
        public int payrollTypeId { get; set; }

        public IEnumerable<SelectListItem> payrollType { get; set; }

    }
}
