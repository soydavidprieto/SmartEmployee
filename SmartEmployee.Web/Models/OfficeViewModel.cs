using Microsoft.AspNetCore.Mvc.Rendering;
using SmartEmployee.Web.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartEmployee.Web.Models
{
    public class OfficeViewModel : Office
    {
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Company")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a pet type.")]
        public int companyId { get; set; }

        public IEnumerable<SelectListItem> company { get; set; }
    }
}
