using SmartEmployee.Web.Data.Entities;
using SmartEmployee.Web.Helpers;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SmartEmployee.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public SeedDb(
            DataContext context,
            IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckRoles();
            var manager = await CheckUserAsync("David", "Prieto", "prietodavid33@hotmail.com", "Admin");
            var customer = await CheckUserAsync("Alejandro", "Chavarro", "soydavidprieto@gmail.com", "Employee");
            await checkApfpAsync();
            await checkArlAsync();
            await checkEpsAsync();
            await checkCcfAsync();
            await checkDocumentTypeAsync();
            await checkEducationTypeAsync();
            await checkGenderAsync();
            await checkLaborRelationshipAsync();
            await checkPayRollTypeAsync();
            await checkPositionAsync();
            await checkScheduleAsync();

        }

        private async Task CheckRoles()
        {
            await _userHelper.CheckRoleAsync("Admin");
            await _userHelper.CheckRoleAsync("Employee");
            await _userHelper.CheckRoleAsync("Human Resources");
        }

        private async Task<User> CheckUserAsync(String userFirstName, string userLastName, string email, string role)
        {
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                user = new User
                {
                    userFirstName = userFirstName,
                    userLastName = userLastName,
                    Email = email
                };

                await _userHelper.AddUserAsync(user, "Prueba");
                await _userHelper.AddUserToRoleAsync(user, role);
            }

            return user;
        }

        private async Task checkApfpAsync()
        {
            var Afp = _context.Afps.FirstOrDefault();
            if (!_context.Afps.Any())
            {
                _context.Afps.Add(new Afp { afpName = "Protección S.A.", afpNit = "800138188" });
                _context.Afps.Add(new Afp { afpName = "Porvenir S.A.", afpNit = "800144331-3" });
                _context.Afps.Add(new Afp { afpName = "Colfondos Pensiones y Cesantías S.A.", afpNit = "8001494962" });
                _context.Afps.Add(new Afp { afpName = "colpensiones", afpNit = "900.336.004-7." });
                await _context.SaveChangesAsync();
            }
        }

        private async Task checkArlAsync()
        {
            var Arl = _context.Arls.FirstOrDefault();
            if (_context.Arls.Any())
            {
                _context.Arls.Add(new Arl { arlName = "Seguros Bolivar S.A.", arlNit = "860.006.359-6" });
                _context.Arls.Add(new Arl { arlName = "Positiva S.A.", arlNit = "860.011.153-6" });
                _context.Arls.Add(new Arl { arlName = "Seguros Alfa S.A.", arlNit = "860.031.979-8" });
                _context.Arls.Add(new Arl { arlName = "Sura Arl S.A.", arlNit = "890903790-5" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task checkEpsAsync()
        {
            var Eps = _context.Epses.FirstOrDefault();
            if (_context.Epses.Any())
            {
                _context.Epses.Add(new Eps { epsName = "Nueva EPS", epsNit = "900156264-2" });
                _context.Epses.Add(new Eps { epsName = "Salud total", epsNit = "800130907-4" });
                _context.Epses.Add(new Eps { epsName = "Famisanar", epsNit = "830003564-7" });
                _context.Epses.Add(new Eps { epsName = "Compensar", epsNit = "860066942-7" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task checkCcfAsync()
        {
            var Ccf = _context.Ccfs.FirstOrDefault();
            if (_context.Ccfs.Any())
            {
                _context.Ccfs.Add(new Ccf { ccfName = "Colsubsidio", ccfNit = "900186224-9" });
                _context.Ccfs.Add(new Ccf { ccfName = "Cafam", ccfNit = "855130905-9" });
                _context.Ccfs.Add(new Ccf { ccfName = "Comcaja", ccfNit = "5003363565-9" });
                _context.Ccfs.Add(new Ccf { ccfName = "Compensar", ccfNit = "860066942-9" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task checkPayRollTypeAsync()
        {
            var PayRollType = _context.PayrollTypes.FirstOrDefault();
            if (_context.PayrollTypes.Any())
            {
                _context.PayrollTypes.Add(new PayrollType { payrollTypeDescription = "Monthly" });
                _context.PayrollTypes.Add(new PayrollType { payrollTypeDescription = "biweekly" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task checkDocumentTypeAsync()
        {
            var DocumenmtType = _context.DocumentTypes.FirstOrDefault();
            if (_context.DocumentTypes.Any())
            {
                _context.DocumentTypes.Add(new DocumentType { documentTypeDescription = "Cedula de Ciudadania" });
                _context.DocumentTypes.Add(new DocumentType { documentTypeDescription = "Pasaporte" });
                _context.DocumentTypes.Add(new DocumentType { documentTypeDescription = "Visa" });
                _context.DocumentTypes.Add(new DocumentType { documentTypeDescription = "Social Security Number" });

                await _context.SaveChangesAsync();
            }
        }

        private async Task checkEducationTypeAsync()
        {
            var EducationType = _context.EducationTypes.FirstOrDefault();
            if (_context.EducationTypes.Any())
            {
                _context.EducationTypes.Add(new EducationType { educationTypeName = "High school" });
                _context.EducationTypes.Add(new EducationType { educationTypeName = "Associate degree" });
                _context.EducationTypes.Add(new EducationType { educationTypeName = "Bachelor degree" });
                _context.EducationTypes.Add(new EducationType { educationTypeName = "Master degree" });
                _context.EducationTypes.Add(new EducationType { educationTypeName = "Doctoral degree" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task checkGenderAsync()
        {
            var Genders = _context.Genders.FirstOrDefault();
            if (_context.Genders.Any())
            {
                _context.Genders.Add(new Gender { genderDescription = "feminine" });
                _context.Genders.Add(new Gender { genderDescription = "male" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task checkLaborRelationshipAsync()
        {
            var LaborRelationship = _context.LaborRelationships.FirstOrDefault();
            if (_context.LaborRelationships.Any())
            {
                _context.LaborRelationships.Add(new LaborRelationship { relationshipName = "Full-time" });
                _context.LaborRelationships.Add(new LaborRelationship { relationshipName = "Fixed-term" });
                _context.LaborRelationships.Add(new LaborRelationship { relationshipName = "Freelance" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task checkPositionAsync()
        {
            var Position = _context.Positions.FirstOrDefault();
            if (_context.Positions.Any())
            {
                _context.Positions.Add(new Position { positionDescription = "SEO" });
                _context.Positions.Add(new Position { positionDescription = "Developer" });
                _context.Positions.Add(new Position { positionDescription = "Grafic Desing" });
                _context.Positions.Add(new Position { positionDescription = "Support Specialists" });
                _context.Positions.Add(new Position { positionDescription = "Human Resources Specialists" });
                _context.Positions.Add(new Position { positionDescription = "Financial Managers" });
                _context.Positions.Add(new Position { positionDescription = "Lawyers" });
                _context.Positions.Add(new Position { positionDescription = "Management Analysts" });
                _context.Positions.Add(new Position { positionDescription = "Receptionists" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task checkScheduleAsync()
        {
            var Schedules = _context.Schedules.FirstOrDefault();
            if (_context.Schedules.Any())
            {
                _context.Schedules.Add(new Schedule { scheduleName = "Full-time", workingHours = "8:00 - 17:30", scheduleBreak = "12:00 - 13:00" });
                _context.Schedules.Add(new Schedule { scheduleName = "Developers", workingHours = "9:00 - 16:00", scheduleBreak = "13:00 - 14:00" });
                _context.Schedules.Add(new Schedule { scheduleName = "SEO", workingHours = "7:00 - 15:30", scheduleBreak = "12:00 - 13:00" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
