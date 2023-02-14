using Microsoft.AspNetCore.Mvc.Rendering;
using SmartEmployee.Web.Data;
using System.Collections.Generic;
using System.Linq;

namespace SmartEmployee.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _context;


        public CombosHelper(DataContext dataContext)
        {
            _context = dataContext;
        }

        public IEnumerable<SelectListItem> GetComboPayrollTypes()
        {
            var list = _context.PayrollTypes.Select(pt => new SelectListItem
            {
                Text = pt.payrollTypeDescription,
                Value = $"{pt.payrollTypeId}"
            }).OrderBy(pt => pt.Text)
                  .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "Select a Payroll type",
                Value = "0"
            });
            return list;
        }

        public IEnumerable<SelectListItem> GetComboCompanies()
        {
            var list = _context.Companies.Select(c => new SelectListItem
            {
                Text = c.companyName,
                Value = $"{c.companyId}"
            }).OrderBy(c => c.Text)
                  .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "Select a company",
                Value = "0"
            });
            return list;
        }

        public IEnumerable<SelectListItem> GetComboGenders()
        {
            var list = _context.Genders.Select(g => new SelectListItem
            {
                Text = g.genderDescription,
                Value = $"{g.genderId}"
            }).OrderBy(g => g.Text)
                  .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "Select a Gender",
                Value = "0"
            });
            return list;
        }

        public IEnumerable<SelectListItem> GetComboPositions()
        {
            var list = _context.Positions.Select(p => new SelectListItem
            {
                Text = p.positionName,
                Value = $"{p.positionId}"
            }).OrderBy(p => p.Text)
                  .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "Select a position",
                Value = "0"
            });
            return list;
        }

        public IEnumerable<SelectListItem> GetComboOffice()
        {
            var list = _context.Offices.Select(o => new SelectListItem
            {
                Text = o.officeName,
                Value = $"{o.officeId}"
            }).OrderBy(o => o.Text)
                  .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "Select an Office",
                Value = "0"
            });
            return list;
        }

        public IEnumerable<SelectListItem> GetComboEps()
        {
            var list = _context.Epses.Select(e => new SelectListItem
            {
                Text = e.epsName,
                Value = $"{e.epsId}"
            }).OrderBy(e => e.Text)
                  .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "Select an Eps",
                Value = "0"
            });
            return list;
        }

        public IEnumerable<SelectListItem> GetComboArl()
        {
            var list = _context.Arls.Select(a => new SelectListItem
            {
                Text = a.arlName,
                Value = $"{a.arlId}"
            }).OrderBy(a => a.Text)
                  .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "Select an Arl",
                Value = "0"
            });
            return list;
        }

        public IEnumerable<SelectListItem> GetComboAfp()
        {
            var list = _context.Afps.Select(af => new SelectListItem
            {
                Text = af.afpName,
                Value = $"{af.afpId}"
            }).OrderBy(af => af.Text)
                  .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "Select an Afp",
                Value = "0"
            });
            return list;
        }

        public IEnumerable<SelectListItem> GetComboCcf()
        {
            var list = _context.Ccfs.Select(cf => new SelectListItem
            {
                Text = cf.ccfName,
                Value = $"{cf.ccfId}"
            }).OrderBy(cf => cf.Text)
                  .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "Select a Ccf",
                Value = "0"
            });
            return list;
        }

        public IEnumerable<SelectListItem> GetComboSchedule()
        {
            var list = _context.Schedules.Select(s => new SelectListItem
            {
                Text = s.scheduleName,
                Value = $"{s.scheduleId}"
            }).OrderBy(s => s.Text)
                  .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "Select a Schedule",
                Value = "0"
            });
            return list;
        }

        public IEnumerable<SelectListItem> GetComboEducationType()
        {
            var list = _context.EducationTypes.Select(Edu => new SelectListItem
            {
                Text = Edu.educationTypeName,
                Value = $"{Edu.educationTypeId}"
            }).OrderBy(Edu => Edu.Text)
                  .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "Select an Education type",
                Value = "0"
            });
            return list;
        }

        public IEnumerable<SelectListItem> GetComboDocumentType()
        {
            var list = _context.DocumentTypes.Select(d => new SelectListItem
            {
                Text = d.documentTypeDescription,
                Value = $"{d.documentTypeId}"
            }).OrderBy(d => d.Text)
                  .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "Select a Document type",
                Value = "0"
            });
            return list;
        }
    }
}
