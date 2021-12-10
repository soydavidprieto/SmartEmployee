using System.Threading.Tasks;
using SmartEmployee.Web.Data;
using SmartEmployee.Web.Data.Entities;
using SmartEmployee.Web.Models;

namespace SmartEmployee.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        private readonly DataContext _context;
        private readonly ICombosHelper _combosHelper;

        public ConverterHelper(
            DataContext dataContext,
            ICombosHelper combosHelper)
        {
            _context = dataContext;
            _combosHelper = combosHelper;
        }
        #region // Company
        public async Task<Company> ToCompanyAsync(CompanyViewModel model, bool isNew)
        {
            var company = new Company
            {
                laboralInfos = model.laboralInfos,
                offices = model.offices,
                companyId = isNew ? 0 : model.companyId,
                companyName = model.companyName,
                companyNit = model.companyNit,
                PayrollType = await _context.PayrollTypes.FindAsync(model.payrollTypeId),
            };

            return company;
        }

        public CompanyViewModel ToCompanyViewModel(Company company)
        {
            return new CompanyViewModel
            {
                laboralInfos = company.laboralInfos,
                offices = company.offices,
                companyId = company.companyId,
                companyName = company.companyName,
                companyNit = company.companyNit,
                payrollTypeId = company.PayrollType.payrollTypeId,
                payrollType = _combosHelper.GetComboPayrollTypes()
            };
        }

        #endregion

        #region // Office
        public async Task<Office> ToOfficeAsync(OfficeViewModel model, bool isNew)
        {
            var office = new Office
            {
                laboralInfos = model.laboralInfos,
                officeName = model.officeName,
                officeId = isNew ? 0 : model.officeId,
                officeAddress = model.officeAddress,
                officePhoneNumber = model.officePhoneNumber,
                Company = await _context.Companies.FindAsync(model.companyId),
            };

            return office;
        }

        public OfficeViewModel ToOfficeViewModel(Office office)
        {
            return new OfficeViewModel
            {
                laboralInfos = office.laboralInfos,
                officeId = office.officeId,
                officeName = office.officeName,
                officeAddress = office.officeAddress,
                officePhoneNumber = office.officePhoneNumber,
                companyId = office.Company.companyId,
                company = _combosHelper.GetComboCompanies()
            };
        }
        #endregion
    }
}
