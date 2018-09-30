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
dbo.[User].EID "UserEID",
dbo.Position.PID,
dbo.Employee.Photo,
dbo.Employee.Status,
dbo.[User].UID

FROM
dbo.Employee
INNER JOIN dbo.Position ON dbo.Employee.PID = dbo.Position.PID
LEFT JOIN dbo.[User] ON dbo.Employee.EID = dbo.[User].EID
WHERE
dbo.Employee.Status = 1;



SELECT
dbo.Stuff.SID,
dbo.Stuff.STID,
dbo.Stuff.Stuff,
dbo.StuffType.Status "StuffTypeStatus",
dbo.StuffType.Type,
dbo.Inventory.INID,
dbo.Inventory.Price,
dbo.Inventory.Status "InventoryStatus"

FROM
dbo.Stuff
INNER JOIN dbo.StuffType ON dbo.Stuff.STID = dbo.StuffType.STID
INNER JOIN dbo.Inventory ON dbo.Inventory.SID = dbo.Stuff.SID
where dbo.Inventory.Status=1;
