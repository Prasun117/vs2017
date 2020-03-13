USE [Newdatabase]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sp_insert]
		@p_empid = 45,
		@p_firstname = N'yash',
		@p_lastname = N'gupta'

SELECT	'Return Value' = @return_value

GO

select * from test2
go

delete test2 where emp_id=100
 insert into test2 select 100,'Steven','King'

 create table Test3
 (
 Business_Unit varchar(20),
Job_Name varchar(20),
Scheduled_Date_Time datetime,

Last_Run_Date_Time datetime,
Next_Run_Date_Time datetime,
Scheduled_By_User varchar(40),
Current_Status varchar(20),
Performance varchar(20),
Parameter_s varchar(20),
Last_3_Runs_Hours time

 )
 select * from Test3