using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace SmartEmployee.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboPayrollTypes();

        IEnumerable<SelectListItem> GetComboCompanies();

        IEnumerable<SelectListItem> GetComboGenders();

        IEnumerable<SelectListItem> GetComboPositions();

        IEnumerable<SelectListItem> GetComboOffice();

        IEnumerable<SelectListItem> GetComboArl();

        IEnumerable<SelectListItem> GetComboAfp();
        IEnumerable<SelectListItem> GetComboEps();

        IEnumerable<SelectListItem> GetComboCcf();

        IEnumerable<SelectListItem> GetComboSchedule();

        IEnumerable<SelectListItem> GetComboEducationType();
        IEnumerable<SelectListItem> GetComboDocumentType();
    }
}