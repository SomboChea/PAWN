ALTER TABLE [dbo].[PawnContract] ADD [PaymentCounts] float NULL;

ALTER TABLE [dbo].[User] ADD [UserStatus] int NULL;

SELECT
dbo.Employee.EID,
dbo.Employee.Name,
dbo.Employee.Email,
dbo.Employee.Gender,
dbo.Employee.Address,
dbo.Employee.Salary,
dbo.Employee.Tel,
dbo.Position.Position,
dbo.[User].Username,
dbo.[User].Password,
dbo.Position.PID,
dbo.Employee.Photo,
dbo.Employee.Status,
dbo.[User].UID,
dbo.[User].UserStatus

FROM
dbo.Employee
INNER JOIN dbo.Position ON dbo.Employee.PID = dbo.Position.PID
INNER JOIN dbo.[User] ON dbo.Employee.UID = dbo.[User].UID
WHERE
dbo.Employee.Status = 1;