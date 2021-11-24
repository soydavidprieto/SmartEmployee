using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartEmployee.Web.Data.Entities;

namespace SmartEmployee.Web.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Afp> Afps { get; set; }

        public DbSet<Arl> Arls { get; set; }

        public DbSet<Ccf> Ccfs { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Contract> Contracts { get; set; }

        public DbSet<DocumentType> DocumentTypes { get; set; }

        public DbSet<EducationInfo> EducationInfos { get; set; }

        public DbSet<EducationType> EducationTypes { get; set;}

        public DbSet<Eps> Epses { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Eps> Eps { get; set; }

        public DbSet<Gender> Genders { get; set; }

        public DbSet<LaboralInfo> LaboralInfos { get; set; }

        public DbSet<LaborRelationship> LaborRelationships { get; set; }

        public DbSet<Office> Offices { get; set; }

        public DbSet<PayrollType> PayrollTypes { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Schedule> Schedules { get; set; }
    }
}