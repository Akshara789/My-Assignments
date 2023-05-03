create or alter procedure sp_GetSalary
@empid int, @sal money output
as
BEGIN
Select @sal=salary from TEST WHERE EmpId=@empId;
End
exec sp_GetSalary