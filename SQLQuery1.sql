USE [StudentDataBase]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[uspCreateDummyStudentData]

SELECT	@return_value as 'Return Value'

GO
