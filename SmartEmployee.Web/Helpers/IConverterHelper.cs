using SmartEmployee.Web.Data.Entities;
using SmartEmployee.Web.Models;
using System.Threading.Tasks;

namespace SmartEmployee.Web.Helpers
{
    public interface IConverterHelper
    {
        Task<Company> ToCompanyAsync(CompanyViewModel model, bool isNew);
        CompanyViewModel ToCompanyViewModel(Company company);

        Task<Office> ToOfficeAsync(OfficeViewModel model, bool isNew);
        OfficeViewModel ToOfficeViewModel(Office office);

        //Task<Employee> ToEmployeeAsync(EmployeeViewModel model, bool isNew);
        //EmployeeViewModel ToEmployeeViewModel(Employee employee);
    }
}