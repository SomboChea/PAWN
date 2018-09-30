ALTER PROCEDURE [dbo].[testing]
  @Interesttype AS int,
  @PawnID AS int
AS
BEGIN
	-- routine body goes here, e.g.
	-- SELECT 'Navicat for SQL Server'
	set datefirst 1;
	DECLARE @PID int = @PawnID;
	DECLARE @InterID int = @Interesttype ;
	DECLARE @price FLOAT = (Select PawnPrice from PawnContract where PawnID=@PID);
	DECLARE @interest FLOAT = (Select InterestRate from PawnContract where PawnID=@PID);
	Declare @Paycount int =(Select PaymentCounts from PawnContract where PawnID=@PID);
	DECLARE @DID int=(Select DID from PawnContract WHERE PawnID=@PawnID);
	DECLARE @DTID int =(Select DTID from Duration WHERE DID=@DID);
	DECLARE @DurationType VARCHAR(10)=(Select DurationType from DurationType where DTID=@DTID);

	DECLARE @days int=(SELECT Duration from Duration where DID=@DID);
	DECLARE @dates date=GETDATE();


	Insert into Schedule VALUES(@PID,GETDATE(),1);
	Declare @SchID int =(Select IDENT_CURRENT('Schedule'));


set @days=(CASE @DurationType
	WHEN 'Day' THEN @days
	WHEN 'Month' THEN DATEDIFF(day, GETDATE(),DATEADD(month, @days, GETDATE()))
	WHEN 'Week' THEN DATEDIFF(day, GETDATE(),DATEADD(week, @days, GETDATE()))
	WHEN 'Year' THEN DATEDIFF(day, GETDATE(),DATEADD(year, @days, GETDATE()))
	ELSE @days
END);

DECLARE @period int=@days/@paycount;

DECLARE @index int=0;
DECLARE @static_amountpay FLOAT=@price/@paycount;
DECLARE @amountleft FLOAT=@price;
DECLARE @amountpay FLOAT;
WHILE @index<@Paycount
BEGIN

DECLARE @paydate date =DATEADD(day, @period, @dates);

WHILE  @paydate in (Select CONVERT(date,StartDate) from Holiday) or DATEPART(dw, @paydate)=7 BEGIN
	
if DATEPART(dw, @paydate)=7
BEGIN
	set @paydate=DATEADD(day, 1, @paydate);
END

if @paydate in (Select CONVERT(date,StartDate) from Holiday)
BEGIN
	DECLARE @daycount int = (SELECT Holiday.DayCount from Holiday where CONVERT(date,Holiday.StartDate)=@paydate);
	set @paydate=DATEADD(day, @daycount, @paydate);
END

END

if @interestType=1
BEGIN
DECLARE  @interestPrice float = @price *@interest/100/@paycount;
set @amountpay=@interestPrice+@static_amountpay;
insert into ScheduleDetail VALUES(@SchID,@amountleft,@interest,@interestPrice,@amountpay,@paydate,2,1);
END





if @interestType=2
BEGIN
set @PID=88;
set @InterID=88;
END

SET @index=@index+1;
SET @dates=DATEADD(day, @period, @dates);

END
	
	
	Select @static_amountpay "static",@amountleft "amountleft",@PID "PawnID",@InterID "InterestTYpe",@price "StuffPrice",@interest "InterestRate",@DID "Duration",@DTID "DTID",@DurationType "DurationType",@SchID "Schedule_ID",@Paycount "PayCount"
	, @index "Index",@days "daycount",@period "Peroid";
END