USE [EMPDB]
GO

DECLARE	@return_value int,
		@sal money

SELECT	@sal = 6000

EXEC	@return_value = [dbo].[sp_GetSalary]
		@empid = 5,
		@sal = @sal OUTPUT

SELECT	@sal as N'@sal'

SELECT	'Return Value' = @return_value

GO
