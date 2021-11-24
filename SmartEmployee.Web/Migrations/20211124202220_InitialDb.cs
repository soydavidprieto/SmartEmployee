using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartEmployee.Web.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Afps",
                columns: table => new
                {
                    afpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    afpName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    afpNit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afps", x => x.afpId);
                });

            migrationBuilder.CreateTable(
                name: "Arls",
                columns: table => new
                {
                    arlId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    arlName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    arlNit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arls", x => x.arlId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ccfs",
                columns: table => new
                {
                    ccfId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ccfName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ccfNit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ccfs", x => x.ccfId);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    documentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    documentTypeDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.documentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "EducationTypes",
                columns: table => new
                {
                    educationTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    educationTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationTypes", x => x.educationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Eps",
                columns: table => new
                {
                    epsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    epsName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    epsNit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eps", x => x.epsId);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    genderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    genderDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.genderId);
                });

            migrationBuilder.CreateTable(
                name: "LaborRelationships",
                columns: table => new
                {
                    relationshipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    relationshipName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaborRelationships", x => x.relationshipId);
                });

            migrationBuilder.CreateTable(
                name: "PayrollTypes",
                columns: table => new
                {
                    payrollTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    payrollTypeDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollTypes", x => x.payrollTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    positionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    positionDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.positionId);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    scheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    scheduleName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    workingHours = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    scheduleBreak = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.scheduleId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    companyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    companyName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    companyNit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    payrollTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.companyId);
                    table.ForeignKey(
                        name: "FK_Companies_PayrollTypes_payrollTypeId",
                        column: x => x.payrollTypeId,
                        principalTable: "PayrollTypes",
                        principalColumn: "payrollTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    userFirstName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    userLastName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    temPasswordUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    companyId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companies_companyId",
                        column: x => x.companyId,
                        principalTable: "Companies",
                        principalColumn: "companyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    officeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    officeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    officeAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    officePhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    companyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.officeId);
                    table.ForeignKey(
                        name: "FK_Offices_Companies_companyId",
                        column: x => x.companyId,
                        principalTable: "Companies",
                        principalColumn: "companyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employeeFirstName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    employeeSurname = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    employeeSecondSurname = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    documentTypeId = table.Column<int>(type: "int", nullable: false),
                    employeeDocument = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    genderId = table.Column<int>(type: "int", nullable: false),
                    employeeBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    employeeFixedPhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    employeeCellPhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    employeeAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    employeeEmail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_DocumentTypes_documentTypeId",
                        column: x => x.documentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "documentTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Genders_genderId",
                        column: x => x.genderId,
                        principalTable: "Genders",
                        principalColumn: "genderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    contractId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeEmmployeeId = table.Column<int>(type: "int", nullable: false),
                    LaborRelationshiprelationshipId = table.Column<int>(type: "int", nullable: true),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.contractId);
                    table.ForeignKey(
                        name: "FK_Contracts_Employees_EmployeeEmmployeeId",
                        column: x => x.EmployeeEmmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_LaborRelationships_LaborRelationshiprelationshipId",
                        column: x => x.LaborRelationshiprelationshipId,
                        principalTable: "LaborRelationships",
                        principalColumn: "relationshipId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EducationInfos",
                columns: table => new
                {
                    EducationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeEmmployeeId = table.Column<int>(type: "int", nullable: false),
                    educationTypeId = table.Column<int>(type: "int", nullable: false),
                    degree = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    institution = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationInfos", x => x.EducationId);
                    table.ForeignKey(
                        name: "FK_EducationInfos_EducationTypes_educationTypeId",
                        column: x => x.educationTypeId,
                        principalTable: "EducationTypes",
                        principalColumn: "educationTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationInfos_Employees_EmployeeEmmployeeId",
                        column: x => x.EmployeeEmmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LaboralInfos",
                columns: table => new
                {
                    laboralIfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeEmmployeeId = table.Column<int>(type: "int", nullable: true),
                    companyId = table.Column<int>(type: "int", nullable: true),
                    employeeIncome = table.Column<DateTime>(type: "datetime2", nullable: false),
                    positionId = table.Column<int>(type: "int", nullable: false),
                    officeId = table.Column<int>(type: "int", nullable: false),
                    epsId = table.Column<int>(type: "int", nullable: false),
                    arlId = table.Column<int>(type: "int", nullable: false),
                    afpId = table.Column<int>(type: "int", nullable: false),
                    ccfId = table.Column<int>(type: "int", nullable: false),
                    scheduleId = table.Column<int>(type: "int", nullable: false),
                    employeeSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaboralInfos", x => x.laboralIfoId);
                    table.ForeignKey(
                        name: "FK_LaboralInfos_Afps_afpId",
                        column: x => x.afpId,
                        principalTable: "Afps",
                        principalColumn: "afpId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LaboralInfos_Arls_arlId",
                        column: x => x.arlId,
                        principalTable: "Arls",
                        principalColumn: "arlId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LaboralInfos_Ccfs_ccfId",
                        column: x => x.ccfId,
                        principalTable: "Ccfs",
                        principalColumn: "ccfId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LaboralInfos_Companies_companyId",
                        column: x => x.companyId,
                        principalTable: "Companies",
                        principalColumn: "companyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LaboralInfos_Employees_EmployeeEmmployeeId",
                        column: x => x.EmployeeEmmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LaboralInfos_Eps_epsId",
                        column: x => x.epsId,
                        principalTable: "Eps",
                        principalColumn: "epsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LaboralInfos_Offices_officeId",
                        column: x => x.officeId,
                        principalTable: "Offices",
                        principalColumn: "officeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LaboralInfos_Positions_positionId",
                        column: x => x.positionId,
                        principalTable: "Positions",
                        principalColumn: "positionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LaboralInfos_Schedules_scheduleId",
                        column: x => x.scheduleId,
                        principalTable: "Schedules",
                        principalColumn: "scheduleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_companyId",
                table: "AspNetUsers",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_payrollTypeId",
                table: "Companies",
                column: "payrollTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_EmployeeEmmployeeId",
                table: "Contracts",
                column: "EmployeeEmmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_LaborRelationshiprelationshipId",
                table: "Contracts",
                column: "LaborRelationshiprelationshipId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationInfos_educationTypeId",
                table: "EducationInfos",
                column: "educationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationInfos_EmployeeEmmployeeId",
                table: "EducationInfos",
                column: "EmployeeEmmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_documentTypeId",
                table: "Employees",
                column: "documentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_genderId",
                table: "Employees",
                column: "genderId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_userId",
                table: "Employees",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_LaboralInfos_afpId",
                table: "LaboralInfos",
                column: "afpId");

            migrationBuilder.CreateIndex(
                name: "IX_LaboralInfos_arlId",
                table: "LaboralInfos",
                column: "arlId");

            migrationBuilder.CreateIndex(
                name: "IX_LaboralInfos_ccfId",
                table: "LaboralInfos",
                column: "ccfId");

            migrationBuilder.CreateIndex(
                name: "IX_LaboralInfos_companyId",
                table: "LaboralInfos",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_LaboralInfos_EmployeeEmmployeeId",
                table: "LaboralInfos",
                column: "EmployeeEmmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LaboralInfos_epsId",
                table: "LaboralInfos",
                column: "epsId");

            migrationBuilder.CreateIndex(
                name: "IX_LaboralInfos_officeId",
                table: "LaboralInfos",
                column: "officeId");

            migrationBuilder.CreateIndex(
                name: "IX_LaboralInfos_positionId",
                table: "LaboralInfos",
                column: "positionId");

            migrationBuilder.CreateIndex(
                name: "IX_LaboralInfos_scheduleId",
                table: "LaboralInfos",
                column: "scheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Offices_companyId",
                table: "Offices",
                column: "companyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "EducationInfos");

            migrationBuilder.DropTable(
                name: "LaboralInfos");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "LaborRelationships");

            migrationBuilder.DropTable(
                name: "EducationTypes");

            migrationBuilder.DropTable(
                name: "Afps");

            migrationBuilder.DropTable(
                name: "Arls");

            migrationBuilder.DropTable(
                name: "Ccfs");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Eps");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "PayrollTypes");
        }
    }
}
