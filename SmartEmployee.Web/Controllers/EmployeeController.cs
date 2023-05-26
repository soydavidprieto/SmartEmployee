using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartEmployee.Web.Data;
using SmartEmployee.Web.Data.Entities;
using SmartEmployee.Web.Helpers;
using SmartEmployee.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartEmployee.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly DataContext _context;
        private readonly IConverterHelper _coverterHelper;
        private readonly ICombosHelper _combosHelper;
        private readonly IUserHelper _userHelper;

        public EmployeeController(DataContext dataContext,
                                  IConverterHelper coverterHelper,
                                  ICombosHelper combosHelper,
                                  IUserHelper userHelper)
        {
            _context = dataContext;
            _coverterHelper = coverterHelper;
            _combosHelper = combosHelper;
            _userHelper = userHelper;
        }

        public IActionResult IndexEmployee()
        {
            return View(_context.Employees
        .Include(o => o.User)
        .Include(l => l.LaboralInfos)
        .ThenInclude(l=> l.Company)
        .Include(l=> l.LaboralInfos)
        .ThenInclude(l=>l.Position));
        }

        #region  AddEmployee
        public IActionResult AddEmployee()
        {
            var model = new EmployeeViewModel
            {
                Genders = _combosHelper.GetComboGenders(),
                DocumentTypes = _combosHelper.GetComboDocumentType(),
                Companies = _combosHelper.GetComboCompanies(),
                Positions = _combosHelper.GetComboPositions(),
                Offices = _combosHelper.GetComboOffice(),
                Eps = _combosHelper.GetComboEps(),
                Arl = _combosHelper.GetComboArl(),
                Afp = _combosHelper.GetComboAfp(),
                Ccf = _combosHelper.GetComboCcf(),
                Schedule = _combosHelper.GetComboSchedule(),
                EducationType = _combosHelper.GetComboEducationType()

            };
            model.Genders = _combosHelper.GetComboGenders();
            model.DocumentTypes = _combosHelper.GetComboDocumentType();
            model.Companies = _combosHelper.GetComboCompanies();
            model.Positions = _combosHelper.GetComboPositions();
            model.Offices = _combosHelper.GetComboOffice();
            model.Eps = _combosHelper.GetComboEps();
            model.Arl = _combosHelper.GetComboArl();
            model.Afp = _combosHelper.GetComboAfp();
            model.Ccf = _combosHelper.GetComboCcf();
            model.Schedule = _combosHelper.GetComboSchedule();
            model.EducationType = _combosHelper.GetComboEducationType();
            ModelState.AddModelError(string.Empty, "One o more files are incorrect");
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEmployee(EmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {

                    firstName = model.firstName,
                    surname = model.surname,
                    secondSurname = model.secondSurname,
                    Email = model.email
                };
                var response = await _userHelper.AddUserAsync(user, model.Password);
                if (response.Succeeded)
                {
                    var userInDb = await _userHelper.GetUserByEmailAsync(model.email);
                    await _userHelper.AddUserToRoleAsync(userInDb, "Employee");
                    await _context.SaveChangesAsync();

                    var employee = new Employee
                    {
                        User = userInDb,
                        Gender = await _context.Genders.FindAsync(model.genderId),
                        DocumentType = await _context.DocumentTypes.FindAsync(model.documentTypeId),
                        employeeDocument = model.employeeDocument,
                        employeeBirth = model.employeeBirth,
                        employeeFixedPhone = model.employeeFixedPhone,
                        employeeCellPhone = model.employeeCellPhone,
                        employeeAddress = model.employeeAddress
                    };
                    _context.Employees.Add(employee);
                    await _context.SaveChangesAsync();

                    var laboralInfo = new LaboralInfo
                    {
                        Employee = employee,
                        Company = await _context.Companies.FindAsync(model.companyId),
                        employeeIncome = model.employeeIncome,
                        Position = await _context.Positions.FindAsync(model.positionId),
                        Office = await _context.Offices.FindAsync(model.officeId),
                        Eps = await _context.Eps.FindAsync(model.epsId),
                        Arl = await _context.Arls.FindAsync(model.arlId),
                        Afp = await _context.Afps.FindAsync(model.afpId),
                        Ccf = await _context.Ccfs.FindAsync(model.ccfId),
                        Schedule = await _context.Schedules.FindAsync(model.scheduleId),
                        employeeSalary = model.employeeSalary
                    };
                    _context.LaboralInfos.Add(laboralInfo);
                    await _context.SaveChangesAsync();

                    var educationInfo = new EducationInfo
                    {
                        Employee = employee,
                        EducationType = await _context.EducationTypes.FindAsync(model.educationTypeId),
                        degree = model.degree,
                        institution = model.institution,
                        startDate = model.startDate,
                        endDate = model.endDate
                    };
                    _context.EducationInfos.Add(educationInfo);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("IndexEmployee");

                }

            }
            model.Genders = _combosHelper.GetComboGenders();
            model.DocumentTypes = _combosHelper.GetComboDocumentType();
            model.Companies = _combosHelper.GetComboCompanies();
            model.Positions = _combosHelper.GetComboPositions();
            model.Offices = _combosHelper.GetComboOffice();
            model.Eps = _combosHelper.GetComboEps();
            model.Arl = _combosHelper.GetComboArl();
            model.Afp = _combosHelper.GetComboAfp();
            model.Ccf = _combosHelper.GetComboCcf();
            model.Schedule = _combosHelper.GetComboSchedule();
            model.EducationType = _combosHelper.GetComboEducationType();
            return View(model);
        }
        #endregion

        #region  Details Employee
        public async Task<IActionResult> DetailsEmployee(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .Include(o => o.User)
                .Include(o => o.EducationInfos)
                .ThenInclude(e => e.EducationType)
                .Include(o => o.LaboralInfos)
                .ThenInclude(o => o.Afp)
                .Include(o => o.LaboralInfos)
                .ThenInclude(o => o.Arl)
                .Include(o => o.LaboralInfos)
                .ThenInclude(o => o.Eps)
                .Include(o => o.LaboralInfos)
                .ThenInclude(o => o.Ccf)
                .Include(o => o.LaboralInfos)
                .ThenInclude(o => o.Company)
                .Include(o => o.LaboralInfos)
                .ThenInclude(o => o.Position)
                .Include(o => o.LaboralInfos)
                .ThenInclude(o => o.Office)
                .Include(o => o.LaboralInfos)
                .ThenInclude(o => o.Schedule)
                .Include(o => o.LaboralInfos)
                .FirstOrDefaultAsync(m => m.EmmployeeId == id);

            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
        #endregion
        
    }
}