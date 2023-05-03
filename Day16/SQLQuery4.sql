create or alter PROCEDURE ShowEmpWithId(@empid int)
AS
BEGIN
SELECT * FROM TEST where EMPId= @empId;
end
exec ShowEmpWithId 2;