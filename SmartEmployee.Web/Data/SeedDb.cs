using SmartEmployee.Web.Data.Entities;
using SmartEmployee.Web.Helpers;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SmartEmployee.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _dataContext;
        private readonly IUserHelper _userHelper;

        public SeedDb(
            DataContext context,
            IUserHelper userHelper)
        {
            _dataContext = context;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _dataContext.Database.EnsureCreatedAsync();
            await CheckRoles();
            await checkPayRollTypeAsync();
            await CheckCompaniesAsync();
            var Admin = await CheckUserAsync("David", "Prieto", "Chavarro", "soydavidprieto@gmail.com", "Admin");
            var Emmployee = await CheckUserAsync("Juan", "Rodriguez", "Gonzales", "prietodavid33@hotmail.com", "Employee");
            await checkApfpAsync();
            await checkArlAsync();
            await checkEpsAsync();
            await checkCcfAsync();
            await checkDocumentTypeAsync();
            await checkEducationTypeAsync();
            await checkGenderAsync();
            await checkLaborRelationshipAsync();
            await checkPositionAsync();
            await checkScheduleAsync();

        }

        private async Task CheckRoles()
        {
            await _userHelper.CheckRoleAsync("Admin");
            await _userHelper.CheckRoleAsync("Employee");
            await _userHelper.CheckRoleAsync("Human Resources");
        }

        private async Task<User> CheckUserAsync(string firstName, string surname,string SecondSurname, string email, string role)
        {
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                user = new User
                {
                    firstName = firstName,
                    surname = surname,
                    secondSurname = SecondSurname,
                    Email = email,
                    UserName = email
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, role);
            }

            return user;
        }

        private async Task checkPayRollTypeAsync()
        {
            var PayRollType = _dataContext.PayrollTypes.FirstOrDefault();
            if (!_dataContext.PayrollTypes.Any())
            {
                _dataContext.PayrollTypes.Add(new PayrollType { payrollTypeDescription = "Monthly" });
                _dataContext.PayrollTypes.Add(new PayrollType { payrollTypeDescription = "biweekly" });
                await _dataContext.SaveChangesAsync();
            }
        }

        private async Task CheckCompaniesAsync()
        {
            if (!_dataContext.Companies.Any())
            {
                var Company = _dataContext.Companies.FirstOrDefault();
                var PayrollType = _dataContext.PayrollTypes.FirstOrDefault();
                AddComapany("EasySoftware", "9012365316-9", PayrollType);
                await _dataContext.SaveChangesAsync();
            }
        }

        private void AddComapany(string companyName, string companyNit, PayrollType payrollType)
        {
            _dataContext.Companies.Add(new Company
            {
                companyName = companyName,
                companyNit = companyNit,
                PayrollType = payrollType,
            });
        }


        
        

        private async Task checkApfpAsync()
        {
            var Afp = _dataContext.Afps.FirstOrDefault();
            if (!_dataContext.Afps.Any())
            {
                _dataContext.Afps.Add(new Afp { afpName = "Protección S.A.", afpNit = "800138188" });
                _dataContext.Afps.Add(new Afp { afpName = "Porvenir S.A.", afpNit = "800144331-3" });
                _dataContext.Afps.Add(new Afp { afpName = "Colfondos Pensiones y Cesantías S.A.", afpNit = "8001494962" });
                _dataContext.Afps.Add(new Afp { afpName = "colpensiones", afpNit = "900.336.004-7." });
                await _dataContext.SaveChangesAsync();
            }
        }

        private async Task checkArlAsync()
        {
            var Arl = _dataContext.Arls.FirstOrDefault();
            if (!_dataContext.Arls.Any())
            {
                _dataContext.Arls.Add(new Arl { arlName = "Seguros Bolivar S.A.", arlNit = "860.006.359-6" });
                _dataContext.Arls.Add(new Arl { arlName = "Positiva S.A.", arlNit = "860.011.153-6" });
                _dataContext.Arls.Add(new Arl { arlName = "Seguros Alfa S.A.", arlNit = "860.031.979-8" });
                _dataContext.Arls.Add(new Arl { arlName = "Sura Arl S.A.", arlNit = "890903790-5" });
                await _dataContext.SaveChangesAsync();
            }
        }

        private async Task checkEpsAsync()
        {
            var Eps = _dataContext.Epses.FirstOrDefault();
            if (!_dataContext.Epses.Any())
            {
                _dataContext.Epses.Add(new Eps { epsName = "Nueva EPS", epsNit = "900156264-2" });
                _dataContext.Epses.Add(new Eps { epsName = "Salud total", epsNit = "800130907-4" });
                _dataContext.Epses.Add(new Eps { epsName = "Famisanar", epsNit = "830003564-7" });
                _dataContext.Epses.Add(new Eps { epsName = "Compensar", epsNit = "860066942-7" });
                await _dataContext.SaveChangesAsync();
            }
        }

        private async Task checkCcfAsync()
        {
            var Ccf = _dataContext.Ccfs.FirstOrDefault();
            if (!_dataContext.Ccfs.Any())
            {
                _dataContext.Ccfs.Add(new Ccf { ccfName = "Colsubsidio", ccfNit = "900186224-9" });
                _dataContext.Ccfs.Add(new Ccf { ccfName = "Cafam", ccfNit = "855130905-9" });
                _dataContext.Ccfs.Add(new Ccf { ccfName = "Comcaja", ccfNit = "5003363565-9" });
                _dataContext.Ccfs.Add(new Ccf { ccfName = "Compensar", ccfNit = "860066942-9" });
                await _dataContext.SaveChangesAsync();
            }
        }

        

        private async Task checkDocumentTypeAsync()
        {
            var DocumenmtType = _dataContext.DocumentTypes.FirstOrDefault();
            if (!_dataContext.DocumentTypes.Any())
            {
                _dataContext.DocumentTypes.Add(new DocumentType { documentTypeDescription = "Cedula de Ciudadania" });
                _dataContext.DocumentTypes.Add(new DocumentType { documentTypeDescription = "Pasaporte" });
                _dataContext.DocumentTypes.Add(new DocumentType { documentTypeDescription = "Visa" });
                _dataContext.DocumentTypes.Add(new DocumentType { documentTypeDescription = "Social Security Number" });

                await _dataContext.SaveChangesAsync();
            }
        }

        private async Task checkEducationTypeAsync()
        {
            var EducationType = _dataContext.EducationTypes.FirstOrDefault();
            if (!_dataContext.EducationTypes.Any())
            {
                _dataContext.EducationTypes.Add(new EducationType { educationTypeName = "High school" });
                _dataContext.EducationTypes.Add(new EducationType { educationTypeName = "Associate degree" });
                _dataContext.EducationTypes.Add(new EducationType { educationTypeName = "Bachelor degree" });
                _dataContext.EducationTypes.Add(new EducationType { educationTypeName = "Master degree" });
                _dataContext.EducationTypes.Add(new EducationType { educationTypeName = "Doctoral degree" });
                await _dataContext.SaveChangesAsync();
            }
        }

        private async Task checkGenderAsync()
        {
            var Genders = _dataContext.Genders.FirstOrDefault();
            if (!_dataContext.Genders.Any())
            {
                _dataContext.Genders.Add(new Gender { genderDescription = "feminine" });
                _dataContext.Genders.Add(new Gender { genderDescription = "male" });
                await _dataContext.SaveChangesAsync();
            }
        }

        private async Task checkLaborRelationshipAsync()
        {
            var LaborRelationship = _dataContext.LaborRelationships.FirstOrDefault();
            if (!_dataContext.LaborRelationships.Any())
            {
                _dataContext.LaborRelationships.Add(new LaborRelationship { relationshipName = "Full-time" });
                _dataContext.LaborRelationships.Add(new LaborRelationship { relationshipName = "Fixed-term" });
                _dataContext.LaborRelationships.Add(new LaborRelationship { relationshipName = "Freelance" });
                await _dataContext.SaveChangesAsync();
            }
        }

        private async Task checkPositionAsync()
        {
            var Position = _dataContext.Positions.FirstOrDefault();
            if (!_dataContext.Positions.Any())
            {
                _dataContext.Positions.Add(new Position { positionDescription = "SEO" });
                _dataContext.Positions.Add(new Position { positionDescription = "Developer" });
                _dataContext.Positions.Add(new Position { positionDescription = "Grafic Desing" });
                _dataContext.Positions.Add(new Position { positionDescription = "Support Specialists" });
                _dataContext.Positions.Add(new Position { positionDescription = "Human Resources Specialists" });
                _dataContext.Positions.Add(new Position { positionDescription = "Financial Managers" });
                _dataContext.Positions.Add(new Position { positionDescription = "Lawyers" });
                _dataContext.Positions.Add(new Position { positionDescription = "Management Analysts" });
                _dataContext.Positions.Add(new Position { positionDescription = "Receptionists" });
                await _dataContext.SaveChangesAsync();
            }
        }

        private async Task checkScheduleAsync()
        {
            var Schedules = _dataContext.Schedules.FirstOrDefault();
            if (!_dataContext.Schedules.Any())
            {
                _dataContext.Schedules.Add(new Schedule { scheduleName = "Full-time", workingHours = "8:00 - 17:30", scheduleBreak = "12:00 - 13:00" });
                _dataContext.Schedules.Add(new Schedule { scheduleName = "Developers", workingHours = "9:00 - 16:00", scheduleBreak = "13:00 - 14:00" });
                _dataContext.Schedules.Add(new Schedule { scheduleName = "SEO", workingHours = "7:00 - 15:30", scheduleBreak = "12:00 - 13:00" });
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
