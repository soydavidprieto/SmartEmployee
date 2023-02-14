ALTER PROCEDURE SP_AddEmployee(
@userid nvarchar(450),
@documentTypeid int,
@employeeDocument varchar (50),
@genderId int,
@employeeBirth Date,
@employeeFixedPhone varchar (20),
@employeeCellPhone varchar (20),
@employeeAddress varchar (100),
@companyId int,
@positionId int,
@officeId int,
@epsId int,
@arlId int,
@afpId int,
@ccfId int,
@scheduleId int,
@employeeIncome Date,
@employeeSalary decimal,
@educationTypeId int,
@degree varchar (200),
@institution varchar (150),
@startDate Date,
@endDate Date
)
AS
SET NOCOUNT ON

If not exists (select * from Employees where employeeDocument = @employeeDocument)
begin
insert into Employees (userId, documentTypeId, employeeDocument, genderId, employeeBirth, employeeFixedPhone, employeeCellPhone, employeeAddress)
        values (@userId, @documentTypeid, @employeeDocument, @genderId, @employeeBirth, @employeeFixedPhone, @employeeCellPhone, @employeeAddress)

declare @auxEmployeeId int
set @auxEmployeeId = @@IDENTITY

insert into LaboralInfos (EmployeeEmmployeeId, companyId, positionId, officeId, epsId, arlId, afpId, ccfId, scheduleId, employeeInCome, employeeSalary)
	   values (@auxEmployeeId, @companyId, @positionId, @officeId, @epsId, @arlId, @afpId, @ccfId, @scheduleId, @employeeIncome, @employeeSalary)
insert into EducationInfos (EmployeeEmmployeeId, educationTypeId, degree,  institution, startDate, endDate)
       values(@auxEmployeeId, @educationTypeId, @degree,  @institution, @startDate, @endDate)

print 'Success Employee adding'
return

end

else
print 'The employee is already registered in the system'


--exec SP_AddEmployee '626d2019-910a-4f20-9c26-263874454a82', 1, '51922574', 1, '1960-04-02', '7494690', '3223075248', 'Cll113a Sur #8-29', 1, 1, 2, 1, 1 , 1, 1, 1, '2021-01-01', '1000.00', 1, 'Software Engennier', 'Universidad Javeriana', '2012-01-01', '2018-11-30'



