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

        #region // Employee
        //public async Task<Employee> ToEmployeeAsync(EmployeeViewModel model, bool isNew)
        //{
        //    var employee = new Employee
        //    {
               
        //        //employeeId = isNew ? 0 : model.employeeId,
        //        Gender = await _context.Genders.FindAsync(model.genderId),
        //        DocumentType = await _context.DocumentTypes.FindAsync(model.documentTypeId),
        //        employeeDocument = model.employeeDocument,
        //        employeeBirth = model.employeeBirth,
        //        employeeFixedPhone = model.employeeFixedPhone,
        //        employeeCellPhone = model.employeeCellPhone,
        //        employeeAddress = model.employeeAddress
        //    };

        //    return employee;
        //}

        //public EmployeeViewModel ToEmployeeViewModel(Employee employee)
        //{
        //    return new EmployeeViewModel
        //    {
        //        genderId = employee.Gender.genderId,
        //        Genders = _combosHelper.GetComboGenders(),
        //        documentTypeId = employee.DocumentType.documentTypeId,
        //        DocumentTypes = _combosHelper.GetComboDocumentType(),
        //        employeeDocument = employee.employeeDocument,
        //        employeeBirth = employee.employeeBirth,
        //        employeeFixedPhone= employee.employeeFixedPhone,
        //        employeeCellPhone= employee.employeeCellPhone,
        //        employeeAddress= employee.employeeAddress
                
        //    };
        //}

        #endregion
    }
}
