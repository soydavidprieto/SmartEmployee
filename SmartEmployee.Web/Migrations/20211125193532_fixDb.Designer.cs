﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartEmployee.Web.Data;

namespace SmartEmployee.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211125193532_fixDb")]
    partial class fixDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Afp", b =>
                {
                    b.Property<int>("afpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("afpName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("afpNit")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("afpId");

                    b.ToTable("Afps");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Arl", b =>
                {
                    b.Property<int>("arlId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("arlName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("arlNit")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("arlId");

                    b.ToTable("Arls");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Ccf", b =>
                {
                    b.Property<int>("ccfId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ccfName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ccfNit")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ccfId");

                    b.ToTable("Ccfs");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Company", b =>
                {
                    b.Property<int>("companyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("companyName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("companyNit")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("payrollTypeId")
                        .HasColumnType("int");

                    b.HasKey("companyId");

                    b.HasIndex("payrollTypeId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Contract", b =>
                {
                    b.Property<int>("contractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeEmmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("LaborRelationshiprelationshipId")
                        .HasColumnType("int");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.HasKey("contractId");

                    b.HasIndex("EmployeeEmmployeeId");

                    b.HasIndex("LaborRelationshiprelationshipId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.DocumentType", b =>
                {
                    b.Property<int>("documentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("documentTypeDescription")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("documentTypeId");

                    b.ToTable("DocumentTypes");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.EducationInfo", b =>
                {
                    b.Property<int>("EducationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeEmmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("degree")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("educationTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("institution")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EducationId");

                    b.HasIndex("EmployeeEmmployeeId");

                    b.HasIndex("educationTypeId");

                    b.ToTable("EducationInfos");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.EducationType", b =>
                {
                    b.Property<int>("educationTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("educationTypeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("educationTypeId");

                    b.ToTable("EducationTypes");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Employee", b =>
                {
                    b.Property<int>("EmmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("documentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("employeeAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("employeeBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("employeeCellPhone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("employeeDocument")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("employeeEmail")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("employeeFirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("employeeFixedPhone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("employeeSecondSurname")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("employeeSurname")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("genderId")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EmmployeeId");

                    b.HasIndex("documentTypeId");

                    b.HasIndex("genderId");

                    b.HasIndex("userId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Eps", b =>
                {
                    b.Property<int>("epsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("epsName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("epsNit")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("epsId");

                    b.ToTable("Eps");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Gender", b =>
                {
                    b.Property<int>("genderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("genderDescription")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("genderId");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.LaborRelationship", b =>
                {
                    b.Property<int>("relationshipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("relationshipName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("relationshipId");

                    b.ToTable("LaborRelationships");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.LaboralInfo", b =>
                {
                    b.Property<int>("laboralIfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeEmmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("afpId")
                        .HasColumnType("int");

                    b.Property<int>("arlId")
                        .HasColumnType("int");

                    b.Property<int>("ccfId")
                        .HasColumnType("int");

                    b.Property<int?>("companyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("employeeIncome")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("employeeSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("epsId")
                        .HasColumnType("int");

                    b.Property<int>("officeId")
                        .HasColumnType("int");

                    b.Property<int>("positionId")
                        .HasColumnType("int");

                    b.Property<int>("scheduleId")
                        .HasColumnType("int");

                    b.HasKey("laboralIfoId");

                    b.HasIndex("EmployeeEmmployeeId");

                    b.HasIndex("afpId");

                    b.HasIndex("arlId");

                    b.HasIndex("ccfId");

                    b.HasIndex("companyId");

                    b.HasIndex("epsId");

                    b.HasIndex("officeId");

                    b.HasIndex("positionId");

                    b.HasIndex("scheduleId");

                    b.ToTable("LaboralInfos");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Office", b =>
                {
                    b.Property<int>("officeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("companyId")
                        .HasColumnType("int");

                    b.Property<string>("officeAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("officeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("officePhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("officeId");

                    b.HasIndex("companyId");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.PayrollType", b =>
                {
                    b.Property<int>("payrollTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("payrollTypeDescription")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("payrollTypeId");

                    b.ToTable("PayrollTypes");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Position", b =>
                {
                    b.Property<int>("positionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("positionDescription")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("positionId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Schedule", b =>
                {
                    b.Property<int>("scheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("scheduleBreak")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("scheduleName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("workingHours")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("scheduleId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("temPasswordUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userFirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("userImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userLastName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SmartEmployee.Web.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SmartEmployee.Web.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartEmployee.Web.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SmartEmployee.Web.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Company", b =>
                {
                    b.HasOne("SmartEmployee.Web.Data.Entities.PayrollType", "PayrollType")
                        .WithMany("companies")
                        .HasForeignKey("payrollTypeId");

                    b.Navigation("PayrollType");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Contract", b =>
                {
                    b.HasOne("SmartEmployee.Web.Data.Entities.Employee", "Employee")
                        .WithMany("Contracts")
                        .HasForeignKey("EmployeeEmmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartEmployee.Web.Data.Entities.LaborRelationship", "LaborRelationship")
                        .WithMany("Contracts")
                        .HasForeignKey("LaborRelationshiprelationshipId");

                    b.Navigation("Employee");

                    b.Navigation("LaborRelationship");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.EducationInfo", b =>
                {
                    b.HasOne("SmartEmployee.Web.Data.Entities.Employee", "Employee")
                        .WithMany("EducationInfos")
                        .HasForeignKey("EmployeeEmmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartEmployee.Web.Data.Entities.EducationType", "EducationType")
                        .WithMany("EducationInfos")
                        .HasForeignKey("educationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EducationType");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Employee", b =>
                {
                    b.HasOne("SmartEmployee.Web.Data.Entities.DocumentType", "DocumentType")
                        .WithMany("Employees")
                        .HasForeignKey("documentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartEmployee.Web.Data.Entities.Gender", "Gender")
                        .WithMany("Employees")
                        .HasForeignKey("genderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartEmployee.Web.Data.Entities.User", "user")
                        .WithMany("employees")
                        .HasForeignKey("userId");

                    b.Navigation("DocumentType");

                    b.Navigation("Gender");

                    b.Navigation("user");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.LaboralInfo", b =>
                {
                    b.HasOne("SmartEmployee.Web.Data.Entities.Employee", "Employee")
                        .WithMany("LaboralInfos")
                        .HasForeignKey("EmployeeEmmployeeId");

                    b.HasOne("SmartEmployee.Web.Data.Entities.Afp", "Afp")
                        .WithMany("laboralInfos")
                        .HasForeignKey("afpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartEmployee.Web.Data.Entities.Arl", "Arl")
                        .WithMany("LaboralInfos")
                        .HasForeignKey("arlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartEmployee.Web.Data.Entities.Ccf", "Ccf")
                        .WithMany("LaboralInfos")
                        .HasForeignKey("ccfId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartEmployee.Web.Data.Entities.Company", "Company")
                        .WithMany("laboralInfos")
                        .HasForeignKey("companyId");

                    b.HasOne("SmartEmployee.Web.Data.Entities.Eps", "Eps")
                        .WithMany("LaboralInfos")
                        .HasForeignKey("epsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartEmployee.Web.Data.Entities.Office", "Office")
                        .WithMany("laboralInfos")
                        .HasForeignKey("officeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartEmployee.Web.Data.Entities.Position", "Position")
                        .WithMany("LaboralInfos")
                        .HasForeignKey("positionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartEmployee.Web.Data.Entities.Schedule", "Schedule")
                        .WithMany("laboralInfos")
                        .HasForeignKey("scheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Afp");

                    b.Navigation("Arl");

                    b.Navigation("Ccf");

                    b.Navigation("Company");

                    b.Navigation("Employee");

                    b.Navigation("Eps");

                    b.Navigation("Office");

                    b.Navigation("Position");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Office", b =>
                {
                    b.HasOne("SmartEmployee.Web.Data.Entities.Company", "Company")
                        .WithMany("offices")
                        .HasForeignKey("companyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Afp", b =>
                {
                    b.Navigation("laboralInfos");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Arl", b =>
                {
                    b.Navigation("LaboralInfos");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Ccf", b =>
                {
                    b.Navigation("LaboralInfos");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Company", b =>
                {
                    b.Navigation("laboralInfos");

                    b.Navigation("offices");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.DocumentType", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.EducationType", b =>
                {
                    b.Navigation("EducationInfos");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Employee", b =>
                {
                    b.Navigation("Contracts");

                    b.Navigation("EducationInfos");

                    b.Navigation("LaboralInfos");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Eps", b =>
                {
                    b.Navigation("LaboralInfos");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Gender", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.LaborRelationship", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Office", b =>
                {
                    b.Navigation("laboralInfos");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.PayrollType", b =>
                {
                    b.Navigation("companies");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Position", b =>
                {
                    b.Navigation("LaboralInfos");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.Schedule", b =>
                {
                    b.Navigation("laboralInfos");
                });

            modelBuilder.Entity("SmartEmployee.Web.Data.Entities.User", b =>
                {
                    b.Navigation("employees");
                });
#pragma warning restore 612, 618
        }
    }
}
