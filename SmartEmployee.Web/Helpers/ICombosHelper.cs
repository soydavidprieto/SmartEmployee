using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace SmartEmployee.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboPayrollTypes();

        IEnumerable<SelectListItem> GetComboCompanies();
    }
}