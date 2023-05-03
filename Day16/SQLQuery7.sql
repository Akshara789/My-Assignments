DECLARE @employee_id INT



DECLARE @salary DECIMAL(10, 2)

DECLARE @total_salary DECIMAL(10, 2) = 0

DECLARE employee_cursor CURSOR FOR

SELECT EmpId, salary    

FROM TEST

OPEN employee_cursor

FETCH NEXT FROM employee_cursor INTO @employee_id, @salary

WHILE @@FETCH_STATUS = 0

BEGIN

 SET @total_salary = @total_salary + @salary

 FETCH NEXT FROM employee_cursor INTO @employee_id, @salary

END

CLOSE employee_cursor

DEALLOCATE employee_cursor

SELECT @total_salary AS TotalSalary