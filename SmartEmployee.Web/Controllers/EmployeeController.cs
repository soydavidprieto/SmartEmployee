using Microsoft.AspNetCore.Mvc;
using SmartEmployee.Web.Data;
using SmartEmployee.Web.Helpers;

namespace SmartEmployee.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly DataContext _context;
        private readonly IConverterHelper _coverterHelper;
        private readonly ICombosHelper _combosHelper;

        public EmployeeController(DataContext dataContext,
                                  IConverterHelper coverterHelper,
                                  ICombosHelper combosHelper)
        {
            _context = dataContext;
            _coverterHelper = coverterHelper;
            _combosHelper = combosHelper;
        }
    }
}
