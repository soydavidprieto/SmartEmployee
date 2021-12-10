using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using SmartEmployee.Web.Data;
using System.Threading.Tasks;
using SmartEmployee.Web.Data.Entities;
using SmartEmployee.Web.Helpers;
using SmartEmployee.Web.Models;
using Microsoft.AspNetCore.Authorization;

namespace SmartEmployee.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdministrationController : Controller
    {
        private readonly DataContext _context;
        private readonly ICombosHelper _combosHelper;
        private readonly IConverterHelper _converterHelper;

        public AdministrationController(DataContext dataContext,
                                        ICombosHelper combosHelper,
                                        IConverterHelper converterHelper)
        {
            _context = dataContext;
            _combosHelper = combosHelper;
            _converterHelper = converterHelper;
        }

        #region // Company
        public IActionResult IndexCompany()
        {

            return View(_context.Companies
                .Include(c => c.PayrollType
                ));
        }

        #region // Create Company
        public IActionResult CreateCompany()
        {


            var model = new CompanyViewModel
            {
                payrollType = _combosHelper.GetComboPayrollTypes()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompany(CompanyViewModel model)
        {
            if (ModelState.IsValid)
            {
                var isExist = IsCompanyExist(model.companyNit);
                if (isExist)
                {
                    ModelState.AddModelError(string.Empty, "The company is already registered in the system");
                    model.payrollType = _combosHelper.GetComboPayrollTypes();
                    return View(model);
                }
                var company = await _converterHelper.ToCompanyAsync(model, true);
                _context.Companies.Add(company);
                await _context.SaveChangesAsync();
                return RedirectToAction("IndexCompany");
            }
            model.payrollType = _combosHelper.GetComboPayrollTypes();
            return View(model);
        }

        [NonAction]
        public bool IsCompanyExist(string companyNit)
        {
            var v = _context.Companies.Where(a => a.companyNit == companyNit).FirstOrDefault();
            return v != null;
        }
        #endregion

        #region // Edit Company
        public async Task<IActionResult> EditCompany(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies
                .Include(c => c.PayrollType)
                .FirstOrDefaultAsync(c => c.companyId == id);
            if (company == null)
            {
                return NotFound();
            }

            return View(_converterHelper.ToCompanyViewModel(company));
        }

        [HttpPost]
        public async Task<IActionResult> EditCompany(CompanyViewModel model)
        {
            if (ModelState.IsValid)
            {
                var company = await _converterHelper.ToCompanyAsync(model, false);
                _context.Companies.Update(company);
                await _context.SaveChangesAsync();
                return RedirectToAction("IndexCompany");
            }
            model.payrollType = _combosHelper.GetComboPayrollTypes();
            return View(model);
        }
        #endregion

        #region // Delete Company
        public async Task<IActionResult> DeleteCompany(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies
                .FirstOrDefaultAsync(m => m.companyId == id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }


        [HttpPost, ActionName("DeleteCompany")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCompanyConfirmed(int id)
        {
            var company = await _context.Companies.FindAsync(id);
            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexCompany));
        }
        #endregion
        #endregion

        #region // Office
        public IActionResult IndexOffice()
        {

            return View(_context.Offices
                .Include(c => c.Company
                ));
        }

        #region // Create Office
        public IActionResult CreateOffice()
        {


            var model = new OfficeViewModel
            {
                company = _combosHelper.GetComboCompanies()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOffice(OfficeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var isExist = IsOfficeExist(model.officeAddress);
                if (isExist)
                {
                    ModelState.AddModelError(string.Empty, "The Office is already registered in the system");
                    model.company = _combosHelper.GetComboCompanies();
                    return View(model);
                }
                var office = await _converterHelper.ToOfficeAsync(model, true);
                _context.Offices.Add(office);
                await _context.SaveChangesAsync();
                return RedirectToAction("IndexOffice");
            }
            model.company = _combosHelper.GetComboCompanies();
            return View(model);
        }

        [NonAction]
        public bool IsOfficeExist(string officeAddress)
        {
            var v = _context.Offices.Where(a => a.officeAddress == officeAddress).FirstOrDefault();
            return v != null;
        }
        #endregion

        #region // Edit Office
        public async Task<IActionResult> EditOffice(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var office = await _context.Offices
                .Include(c => c.Company)
                .FirstOrDefaultAsync(c => c.officeId == id);
            if (office == null)
            {
                return NotFound();
            }

            return View(_converterHelper.ToOfficeViewModel(office));
        }

        [HttpPost]
        public async Task<IActionResult> EditOffice(OfficeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var office = await _converterHelper.ToOfficeAsync(model, false);
                _context.Offices.Update(office);
                await _context.SaveChangesAsync();
                return RedirectToAction("IndexOffice");
            }
            model.company = _combosHelper.GetComboCompanies();
            return View(model);
        }
        #endregion

        #region // Delete Office
        public async Task<IActionResult> DeleteOffice(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var office = await _context.Offices
                .FirstOrDefaultAsync(c => c.officeId == id);
            if (office == null)
            {
                return NotFound();
            }

            return View(office);
        }


        [HttpPost, ActionName("DeleteOffice")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteOfficeConfirmed(int id)
        {
            var office = await _context.Offices.FindAsync(id);
            _context.Offices.Remove(office);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexOffice));
        }
        #endregion
        #endregion

        #region // positions
        public async Task<IActionResult> IndexPositions()
        {
            return View(await _context.Positions.ToListAsync());
        }

        #region // Create Position
        public IActionResult CreatePosition()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePosition([Bind("positionId, positionDescription")] Position position)
        {
            if (ModelState.IsValid)
            {
                _context.Add(position);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexPositions));
            }
            return View(position);

        }
        #endregion

        #region // Edit Position
        public async Task<IActionResult> EditPosition(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var position = await _context.Positions.FindAsync(id);
            if (position == null)
            {
                return NotFound();
            }
            return View(position);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPosition(int id, [Bind("positionId,positionDescription")] Position position)
        {
            if (id != position.positionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(position);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexPositions));
            }
            return View(position);
        }
        #endregion

        #region // Delete Position
        public async Task<IActionResult> DeletePosition(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var position = await _context.Positions
                .FirstOrDefaultAsync(m => m.positionId == id);
            if (position == null)
            {
                return NotFound();
            }

            return View(position);
        }


        [HttpPost, ActionName("Deleteposition")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePositionConfirmed(int id)
        {
            var position = await _context.Positions.FindAsync(id);
            _context.Positions.Remove(position);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexPositions));
        }
        #endregion
        #endregion

        #region // Payroll Type
        public async Task<IActionResult> IndexPayrollType()
        {
            return View(await _context.PayrollTypes.ToListAsync());
        }

        #region // Create PayrollType
        public IActionResult CreatePayrollType()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePayrollType([Bind("payrollTypeId, payrollTypeDescription")] PayrollType payrollType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(payrollType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexPayrollType));
            }
            return View(payrollType);

        }
        #endregion

        #region // Edit PayrollType
        public async Task<IActionResult> EditPayrollType(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payrollType = await _context.PayrollTypes.FindAsync(id);
            if (payrollType == null)
            {
                return NotFound();
            }
            return View(payrollType);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPayrollType(int id, [Bind("payrollTypeId,payrollTypeDescription")] PayrollType payrollType)
        {
            if (id != payrollType.payrollTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(payrollType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexPayrollType));
            }
            return View(payrollType);
        }
        #endregion

        #region // Delete Position
        public async Task<IActionResult> DeletePayrollType(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payrollType = await _context.PayrollTypes
                .FirstOrDefaultAsync(m => m.payrollTypeId == id);
            if (payrollType == null)
            {
                return NotFound();
            }

            return View(payrollType);
        }


        [HttpPost, ActionName("DeletePayrollType")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePayrollTypeConfirmed(int id)
        {
            var payrollType = await _context.PayrollTypes.FindAsync(id);
            _context.PayrollTypes.Remove(payrollType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexPayrollType));
        }
        #endregion
        #endregion

        #region // Schedule
        public async Task<IActionResult> IndexSchedule()
        {
            return View(await _context.Schedules.ToListAsync());
        }

        #region // Create Schedule
        public IActionResult CreateSchedule()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSchedule([Bind("scheduleId, scheduleName, workingHours, scheduleBreak")]
                                                         Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(schedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexSchedule));
            }
            return View(schedule);
        }
        #endregion

        #region // Edit Schedule
        public async Task<IActionResult> EditSchedule(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedules.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }
            return View(schedule);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditSchedule(int id, [Bind("scheduleId, scheduleName, workingHours, scheduleBreak")]
                                                               Schedule schedule)
        {
            if (id != schedule.scheduleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(schedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexSchedule));
            }
            return View(schedule);
        }
            #endregion

            #region // Delete Shedule
            public async Task<IActionResult> DeleteSchedule(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var schedule = await _context.Schedules
                    .FirstOrDefaultAsync(m => m.scheduleId == id);
                if (schedule == null)
                {
                    return NotFound();
                }

                return View(schedule);
            }


            [HttpPost, ActionName("DeleteSchedule")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteScheduleConfirmed(int id)
            {
                var schedule = await _context.Schedules.FindAsync(id);
                _context.Schedules.Remove(schedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexSchedule));
            }
        #endregion
        #endregion

        #region // Laboral Relationship
        public async Task <IActionResult> IndexRelationship()
        {
            return View(await _context.LaborRelationships.ToListAsync());
        }
        #region // Create Laboral Relationship 
        public IActionResult CreateRelationship()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRelationship(LaborRelationship laborRelationship)
        {
            if(ModelState.IsValid)
            {
                _context.LaborRelationships.Add(laborRelationship);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexRelationship));
            }
            return View(laborRelationship);
        }
        #endregion

        #region // Edit Laboral Relationship
        public async Task<IActionResult> EditRelationship(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var relationship = await _context.LaborRelationships.FindAsync(id);
            if(relationship == null)
            {
                return NotFound();
            }
            return View(relationship);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> EditRelationship(int id, LaborRelationship laborRelationship)
        {
            if(id != laborRelationship.relationshipId)
            {
                return NotFound();
            }

            if(ModelState.IsValid)
            {
                _context.Update(laborRelationship);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexRelationship));
            }
            return View (laborRelationship);
        }
        #endregion

        #region // Delete Laboral Relationship
        public async Task<IActionResult> DeleteRelationship(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var relationship = await _context.LaborRelationships
                .FirstOrDefaultAsync(m => m.relationshipId == id);
            if (relationship == null)
            {
                return NotFound();
            }

            return View(relationship);
        }

        
        [HttpPost, ActionName("DeleteRelationship")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteRelationshipConfirmed(int id)
        {
            var relationship = await _context.LaborRelationships.FindAsync(id);
            _context.LaborRelationships.Remove(relationship);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexRelationship));
        }
        #endregion

        #endregion
    }
}