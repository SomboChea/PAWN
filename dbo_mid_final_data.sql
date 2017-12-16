/*
 Navicat Premium Data Transfer

 Source Server         : SQL Server
 Source Server Type    : SQL Server
 Source Server Version : 14001000
 Source Host           : localhost:1433
 Source Catalog        : SAPAWN
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 14001000
 File Encoding         : 65001

 Date: 16/12/2017 19:48:30
*/


-- ----------------------------
-- Table structure for Buy
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Buy]') AND type IN ('U'))
	DROP TABLE [dbo].[Buy]
GO

CREATE TABLE [dbo].[Buy] (
  [BID] int IDENTITY(1,1) NOT NULL,
  [Date] datetime2(7) NULL,
  [EID] int NULL,
  [CID] int NULL
)
GO

ALTER TABLE [dbo].[Buy] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for BuyDetail
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BuyDetail]') AND type IN ('U'))
	DROP TABLE [dbo].[BuyDetail]
GO

CREATE TABLE [dbo].[BuyDetail] (
  [BID] int NULL,
  [INID] int NULL,
  [Price] money NULL
)
GO

ALTER TABLE [dbo].[BuyDetail] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Customer
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Customer]') AND type IN ('U'))
	DROP TABLE [dbo].[Customer]
GO

CREATE TABLE [dbo].[Customer] (
  [CID] int IDENTITY(1,1) NOT NULL,
  [Name] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Gender] varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Tel] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [IDTypeID] int NULL,
  [Address] varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Attachement] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Status] smallint NULL
)
GO

ALTER TABLE [dbo].[Customer] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for DurationType
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[DurationType]') AND type IN ('U'))
	DROP TABLE [dbo].[DurationType]
GO

CREATE TABLE [dbo].[DurationType] (
  [DTID] int IDENTITY(1,1) NOT NULL,
  [DurationType] varchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
)
GO

ALTER TABLE [dbo].[DurationType] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Employee
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type IN ('U'))
	DROP TABLE [dbo].[Employee]
GO

CREATE TABLE [dbo].[Employee] (
  [EID] int IDENTITY(1,1) NOT NULL,
  [Name] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
  [Gender] varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Address] varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Email] varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Tel] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Salary] money NULL,
  [Photo] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Status] smallint NULL,
  [PID] int NULL
)
GO

ALTER TABLE [dbo].[Employee] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of [Employee]
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Employee] ON
GO

INSERT INTO [dbo].[Employee] ([EID], [Name], [Gender], [Address], [Email], [Tel], [Salary], [Photo], [Status], [PID]) VALUES (N'1', N'Sambo Chea', N'Male', N'Phnom Penh', N'sombochea100@gmail.com', N'0769995149', N'100.0000', NULL, N'1', N'1')
GO

INSERT INTO [dbo].[Employee] ([EID], [Name], [Gender], [Address], [Email], [Tel], [Salary], [Photo], [Status], [PID]) VALUES (N'2', N'Meanika', N'Female', N'Phnom Penh', N'meanika@gmail.com', N'081999119', N'120.0000', NULL, N'1', N'2')
GO

SET IDENTITY_INSERT [dbo].[Employee] OFF
GO


-- ----------------------------
-- Table structure for Holiday
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Holiday]') AND type IN ('U'))
	DROP TABLE [dbo].[Holiday]
GO

CREATE TABLE [dbo].[Holiday] (
  [HID] int IDENTITY(1,1) NOT NULL,
  [Description] varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [StartDate] datetime2(7) NULL,
  [EndDate] datetime2(7) NULL,
  [DayCount] int NULL
)
GO

ALTER TABLE [dbo].[Holiday] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Identity
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Identity]') AND type IN ('U'))
	DROP TABLE [dbo].[Identity]
GO

CREATE TABLE [dbo].[Identity] (
  [IDTypeID] int IDENTITY(1,1) NOT NULL,
  [IDType] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
)
GO

ALTER TABLE [dbo].[Identity] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Inventory
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Inventory]') AND type IN ('U'))
	DROP TABLE [dbo].[Inventory]
GO

CREATE TABLE [dbo].[Inventory] (
  [INID] int IDENTITY(1,1) NOT NULL,
  [SID] int NULL,
  [Price] money NULL,
  [Status] smallint NULL
)
GO

ALTER TABLE [dbo].[Inventory] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Option
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Option]') AND type IN ('U'))
	DROP TABLE [dbo].[Option]
GO

CREATE TABLE [dbo].[Option] (
  [OptionID] int IDENTITY(1,1) NOT NULL,
  [Option_EN] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
  [Option_KH] nvarchar(50) COLLATE Khmer_100_BIN2 NULL,
  [Tag] varchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
)
GO

ALTER TABLE [dbo].[Option] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of [Option]
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Option] ON
GO

INSERT INTO [dbo].[Option] ([OptionID], [Option_EN], [Option_KH], [Tag]) VALUES (N'1', N'Dashboard', N'ទំព័រដើម', N'home')
GO

INSERT INTO [dbo].[Option] ([OptionID], [Option_EN], [Option_KH], [Tag]) VALUES (N'4', N'New Pawn', N'បញ្ចាំ', N'pawn')
GO

INSERT INTO [dbo].[Option] ([OptionID], [Option_EN], [Option_KH], [Tag]) VALUES (N'5', N'Stuff Pawn', N'វត្ថុបញ្ចាំ', N'stuff')
GO

INSERT INTO [dbo].[Option] ([OptionID], [Option_EN], [Option_KH], [Tag]) VALUES (N'6', N'Inventory', N'ទំនិញ', N'inventory')
GO

INSERT INTO [dbo].[Option] ([OptionID], [Option_EN], [Option_KH], [Tag]) VALUES (N'7', N'Customers', N'អតិថិជន', N'customer')
GO

INSERT INTO [dbo].[Option] ([OptionID], [Option_EN], [Option_KH], [Tag]) VALUES (N'8', N'Employees', N'បុលិគ្គ', N'employee')
GO

INSERT INTO [dbo].[Option] ([OptionID], [Option_EN], [Option_KH], [Tag]) VALUES (N'9', N'Reports', N'របាយការណ៏', N'report')
GO

INSERT INTO [dbo].[Option] ([OptionID], [Option_EN], [Option_KH], [Tag]) VALUES (N'10', N'Holiday', N'ថ្ងៃសម្រាក', N'holiday')
GO

SET IDENTITY_INSERT [dbo].[Option] OFF
GO


-- ----------------------------
-- Table structure for PawnContract
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PawnContract]') AND type IN ('U'))
	DROP TABLE [dbo].[PawnContract]
GO

CREATE TABLE [dbo].[PawnContract] (
  [PawnID] int IDENTITY(1,1) NOT NULL,
  [Date] datetime2(7) NULL,
  [CID] int NULL,
  [EID] int NULL,
  [SID] int NULL,
  [PawnPrice] money NULL,
  [Duration] int NULL,
  [InterestRate] int NULL,
  [Attachement] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Status] smallint NULL,
  [DIDT] int NULL
)
GO

ALTER TABLE [dbo].[PawnContract] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for PayType
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PayType]') AND type IN ('U'))
	DROP TABLE [dbo].[PayType]
GO

CREATE TABLE [dbo].[PayType] (
  [PTID] int IDENTITY(1,1) NOT NULL,
  [PayType] varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
)
GO

ALTER TABLE [dbo].[PayType] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Position
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Position]') AND type IN ('U'))
	DROP TABLE [dbo].[Position]
GO

CREATE TABLE [dbo].[Position] (
  [PID] int IDENTITY(1,1) NOT NULL,
  [Position] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
)
GO

ALTER TABLE [dbo].[Position] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of [Position]
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Position] ON
GO

INSERT INTO [dbo].[Position] ([PID], [Position]) VALUES (N'1', N'Admin')
GO

INSERT INTO [dbo].[Position] ([PID], [Position]) VALUES (N'2', N'User')
GO

SET IDENTITY_INSERT [dbo].[Position] OFF
GO


-- ----------------------------
-- Table structure for RoleOption
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[RoleOption]') AND type IN ('U'))
	DROP TABLE [dbo].[RoleOption]
GO

CREATE TABLE [dbo].[RoleOption] (
  [RoleID] int NULL,
  [OptionID] int NULL
)
GO

ALTER TABLE [dbo].[RoleOption] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of [RoleOption]
-- ----------------------------
INSERT INTO [dbo].[RoleOption]  VALUES (N'1', N'1')
GO

INSERT INTO [dbo].[RoleOption]  VALUES (N'1', N'4')
GO

INSERT INTO [dbo].[RoleOption]  VALUES (N'1', N'5')
GO

INSERT INTO [dbo].[RoleOption]  VALUES (N'1', N'6')
GO

INSERT INTO [dbo].[RoleOption]  VALUES (N'1', N'7')
GO

INSERT INTO [dbo].[RoleOption]  VALUES (N'1', N'8')
GO

INSERT INTO [dbo].[RoleOption]  VALUES (N'1', N'9')
GO

INSERT INTO [dbo].[RoleOption]  VALUES (N'1', N'10')
GO

INSERT INTO [dbo].[RoleOption]  VALUES (N'2', N'1')
GO

INSERT INTO [dbo].[RoleOption]  VALUES (N'2', N'4')
GO

INSERT INTO [dbo].[RoleOption]  VALUES (NULL, NULL)
GO


-- ----------------------------
-- Table structure for Sale
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Sale]') AND type IN ('U'))
	DROP TABLE [dbo].[Sale]
GO

CREATE TABLE [dbo].[Sale] (
  [SaleID] int IDENTITY(1,1) NOT NULL,
  [Date] datetime2(7) NULL,
  [EID] int NULL,
  [TotalAmount] money NULL,
  [CID] int NULL
)
GO

ALTER TABLE [dbo].[Sale] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for SaleDetail
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[SaleDetail]') AND type IN ('U'))
	DROP TABLE [dbo].[SaleDetail]
GO

CREATE TABLE [dbo].[SaleDetail] (
  [SaleID] int NULL,
  [InID] int NULL,
  [Price] money NULL
)
GO

ALTER TABLE [dbo].[SaleDetail] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Schedule
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Schedule]') AND type IN ('U'))
	DROP TABLE [dbo].[Schedule]
GO

CREATE TABLE [dbo].[Schedule] (
  [SCHID] int IDENTITY(1,1) NOT NULL,
  [PawnID] int NULL,
  [MakeDate] datetime2(7) NULL,
  [Status] smallint NULL,
  [PayCount] smallint NULL
)
GO

ALTER TABLE [dbo].[Schedule] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for ScheduleDetail
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ScheduleDetail]') AND type IN ('U'))
	DROP TABLE [dbo].[ScheduleDetail]
GO

CREATE TABLE [dbo].[ScheduleDetail] (
  [SCHID] int NOT NULL,
  [AmountLeft] money NULL,
  [InterestRate] int NULL,
  [Interest] money NULL,
  [AmountPay] money NULL,
  [PayDate] datetime2(7) NULL,
  [PTID] int NULL,
  [Status] int NULL
)
GO

ALTER TABLE [dbo].[ScheduleDetail] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Stuff
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Stuff]') AND type IN ('U'))
	DROP TABLE [dbo].[Stuff]
GO

CREATE TABLE [dbo].[Stuff] (
  [SID] int IDENTITY(1,1) NOT NULL,
  [Stuff] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [STID] int NULL
)
GO

ALTER TABLE [dbo].[Stuff] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for StuffType
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[StuffType]') AND type IN ('U'))
	DROP TABLE [dbo].[StuffType]
GO

CREATE TABLE [dbo].[StuffType] (
  [STID] int IDENTITY(1,1) NOT NULL,
  [Type] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [Status] int NULL
)
GO

ALTER TABLE [dbo].[StuffType] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for User
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type IN ('U'))
	DROP TABLE [dbo].[User]
GO

CREATE TABLE [dbo].[User] (
  [UID] int IDENTITY(1,1) NOT NULL,
  [Username] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
  [Password] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
  [Status] smallint NOT NULL,
  [EID] int NULL
)
GO

ALTER TABLE [dbo].[User] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of [User]
-- ----------------------------
SET IDENTITY_INSERT [dbo].[User] ON
GO

INSERT INTO [dbo].[User] ([UID], [Username], [Password], [Status], [EID]) VALUES (N'1', N'sombochea', N'ms', N'1', N'1')
GO

INSERT INTO [dbo].[User] ([UID], [Username], [Password], [Status], [EID]) VALUES (N'3', N'meanika', N'123', N'1', N'2')
GO

SET IDENTITY_INSERT [dbo].[User] OFF
GO


-- ----------------------------
-- Table structure for WriteBack
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[WriteBack]') AND type IN ('U'))
	DROP TABLE [dbo].[WriteBack]
GO

CREATE TABLE [dbo].[WriteBack] (
  [WBID] int IDENTITY(1,1) NOT NULL,
  [WFID] int NULL,
  [Date] datetime2(7) NULL,
  [Status] int NULL
)
GO

ALTER TABLE [dbo].[WriteBack] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for WriteOff
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[WriteOff]') AND type IN ('U'))
	DROP TABLE [dbo].[WriteOff]
GO

CREATE TABLE [dbo].[WriteOff] (
  [WFID] int IDENTITY(1,1) NOT NULL,
  [PawnID] int NULL,
  [Date] datetime2(7) NULL,
  [Status] int NULL
)
GO

ALTER TABLE [dbo].[WriteOff] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- View structure for viewRoleOption
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewRoleOption]') AND type IN ('V'))
	DROP VIEW [dbo].[viewRoleOption]
GO

CREATE VIEW [dbo].[viewRoleOption] AS SELECT pos.PID, pos.Position, opt.Option_EN, opt.Option_KH, opt.Tag

FROM [Option] opt
INNER JOIN [RoleOption] rpt
ON opt.OptionID = rpt.OptionID
INNER JOIN [Position] pos
ON rpt.RoleID = pos.PID
GO


-- ----------------------------
-- View structure for viewUserRole
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewUserRole]') AND type IN ('V'))
	DROP VIEW [dbo].[viewUserRole]
GO

CREATE VIEW [dbo].[viewUserRole] AS SELECT p.PID, u.UID, u.Username, e.Name, p.Position
FROM [User] u
INNER JOIN [Employee] e
ON u.EID = e.EID
INNER JOIN [Position] p
ON e.PID = p.PID
GO


-- ----------------------------
-- Procedure structure for getRoleOption
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[getRoleOption]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[getRoleOption]
GO

CREATE PROCEDURE [dbo].[getRoleOption] (@posID INT)
AS
BEGIN
	SELECT * 
	FROM viewRoleOption
	WHERE PID = @posID;
END
GO


-- ----------------------------
-- Procedure structure for getUserRole
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[getUserRole]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[getUserRole]
GO

CREATE PROCEDURE [dbo].[getUserRole] (@userID INT)
AS
BEGIN
	SELECT PID FROM viewUserRole
	WHERE UID = @userID;
END
GO


-- ----------------------------
-- Primary Key structure for table Buy
-- ----------------------------
ALTER TABLE [dbo].[Buy] ADD CONSTRAINT [PK__Buy__C6DE0D21B6B9D29C] PRIMARY KEY CLUSTERED ([BID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Customer
-- ----------------------------
ALTER TABLE [dbo].[Customer] ADD CONSTRAINT [PK__Customer__C1F8DC5946B66443] PRIMARY KEY CLUSTERED ([CID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table DurationType
-- ----------------------------
ALTER TABLE [dbo].[DurationType] ADD CONSTRAINT [PK__Duration__2A11E43365B87ED6] PRIMARY KEY CLUSTERED ([DTID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Employee
-- ----------------------------
ALTER TABLE [dbo].[Employee] ADD CONSTRAINT [PK__Employee__C190170BA6F3867B] PRIMARY KEY CLUSTERED ([EID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Holiday
-- ----------------------------
ALTER TABLE [dbo].[Holiday] ADD CONSTRAINT [PK__Holiday__C755152709258CFE] PRIMARY KEY CLUSTERED ([HID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Identity
-- ----------------------------
ALTER TABLE [dbo].[Identity] ADD CONSTRAINT [PK__Identity__3B6BCFA737924AFD] PRIMARY KEY CLUSTERED ([IDTypeID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Inventory
-- ----------------------------
ALTER TABLE [dbo].[Inventory] ADD CONSTRAINT [PK__Inventor__8D355E7B17268DFE] PRIMARY KEY CLUSTERED ([INID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Option
-- ----------------------------
ALTER TABLE [dbo].[Option] ADD CONSTRAINT [PK__Option__92C7A1DF8F8FA3A3] PRIMARY KEY CLUSTERED ([OptionID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table PawnContract
-- ----------------------------
ALTER TABLE [dbo].[PawnContract] ADD CONSTRAINT [PK__PawnCont__9865AE53D18C3D05] PRIMARY KEY CLUSTERED ([PawnID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table PayType
-- ----------------------------
ALTER TABLE [dbo].[PayType] ADD CONSTRAINT [PK__PayType__BCC07F4FB5D5653A] PRIMARY KEY CLUSTERED ([PTID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Position
-- ----------------------------
ALTER TABLE [dbo].[Position] ADD CONSTRAINT [PK__Position__C5775520576DE4FA] PRIMARY KEY CLUSTERED ([PID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Sale
-- ----------------------------
ALTER TABLE [dbo].[Sale] ADD CONSTRAINT [PK__Sale__1EE3C41FE3EE07F4] PRIMARY KEY CLUSTERED ([SaleID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Schedule
-- ----------------------------
ALTER TABLE [dbo].[Schedule] ADD CONSTRAINT [PK__Schedule__C55184C447B696C0] PRIMARY KEY CLUSTERED ([SCHID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Stuff
-- ----------------------------
ALTER TABLE [dbo].[Stuff] ADD CONSTRAINT [PK__Stuff__CA195970839BAAF2] PRIMARY KEY CLUSTERED ([SID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table StuffType
-- ----------------------------
ALTER TABLE [dbo].[StuffType] ADD CONSTRAINT [PK__StuffTyp__A60B1C9884DCD83B] PRIMARY KEY CLUSTERED ([STID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table User
-- ----------------------------
ALTER TABLE [dbo].[User] ADD CONSTRAINT [PK__User__C5B1960251DE4B6F] PRIMARY KEY CLUSTERED ([UID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table WriteBack
-- ----------------------------
ALTER TABLE [dbo].[WriteBack] ADD CONSTRAINT [PK__WriteBac__FAF30A9EC3C7F38D] PRIMARY KEY CLUSTERED ([WBID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table WriteOff
-- ----------------------------
ALTER TABLE [dbo].[WriteOff] ADD CONSTRAINT [PK__WriteOff__FFE34A1899160912] PRIMARY KEY CLUSTERED ([WFID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table Buy
-- ----------------------------
ALTER TABLE [dbo].[Buy] ADD CONSTRAINT [FK__Buy__CID__66603565] FOREIGN KEY ([CID]) REFERENCES [Customer] ([CID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table BuyDetail
-- ----------------------------
ALTER TABLE [dbo].[BuyDetail] ADD CONSTRAINT [FK__BuyDetail__BID__29221CFB] FOREIGN KEY ([BID]) REFERENCES [Buy] ([BID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[BuyDetail] ADD CONSTRAINT [FK__BuyDetail__INID__2CF2ADDF] FOREIGN KEY ([INID]) REFERENCES [Inventory] ([INID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Customer
-- ----------------------------
ALTER TABLE [dbo].[Customer] ADD CONSTRAINT [FK__Customer__IDType__6754599E] FOREIGN KEY ([IDTypeID]) REFERENCES [Identity] ([IDTypeID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Employee
-- ----------------------------
ALTER TABLE [dbo].[Employee] ADD CONSTRAINT [FK__Employee__PID__03F0984C] FOREIGN KEY ([PID]) REFERENCES [Position] ([PID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Inventory
-- ----------------------------
ALTER TABLE [dbo].[Inventory] ADD CONSTRAINT [FK__Inventory__SID__6D0D32F4] FOREIGN KEY ([SID]) REFERENCES [Stuff] ([SID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table PawnContract
-- ----------------------------
ALTER TABLE [dbo].[PawnContract] ADD CONSTRAINT [FK__PawnContra__DIDT__02FC7413] FOREIGN KEY ([DIDT]) REFERENCES [DurationType] ([DTID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[PawnContract] ADD CONSTRAINT [FK__PawnContrac__CID__619B8048] FOREIGN KEY ([CID]) REFERENCES [Customer] ([CID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[PawnContract] ADD CONSTRAINT [FK__PawnContrac__EID__628FA481] FOREIGN KEY ([EID]) REFERENCES [Employee] ([EID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[PawnContract] ADD CONSTRAINT [FK__PawnContrac__SID__6383C8BA] FOREIGN KEY ([SID]) REFERENCES [Stuff] ([SID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table RoleOption
-- ----------------------------
ALTER TABLE [dbo].[RoleOption] ADD CONSTRAINT [FK__RoleOptio__RoleI__02084FDA] FOREIGN KEY ([RoleID]) REFERENCES [Position] ([PID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[RoleOption] ADD CONSTRAINT [FK__RoleOptio__Optio__70DDC3D8] FOREIGN KEY ([OptionID]) REFERENCES [Option] ([OptionID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Sale
-- ----------------------------
ALTER TABLE [dbo].[Sale] ADD CONSTRAINT [FK__Sale__CID__6A30C649] FOREIGN KEY ([CID]) REFERENCES [Customer] ([CID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table SaleDetail
-- ----------------------------
ALTER TABLE [dbo].[SaleDetail] ADD CONSTRAINT [FK__SaleDetai__SaleI__6B24EA82] FOREIGN KEY ([SaleID]) REFERENCES [Sale] ([SaleID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[SaleDetail] ADD CONSTRAINT [FK__SaleDetail__InID__6C190EBB] FOREIGN KEY ([InID]) REFERENCES [Inventory] ([INID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Schedule
-- ----------------------------
ALTER TABLE [dbo].[Schedule] ADD CONSTRAINT [FK__Schedule__PawnID__778AC167] FOREIGN KEY ([PawnID]) REFERENCES [PawnContract] ([PawnID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table ScheduleDetail
-- ----------------------------
ALTER TABLE [dbo].[ScheduleDetail] ADD CONSTRAINT [FK__ScheduleDe__PTID__656C112C] FOREIGN KEY ([PTID]) REFERENCES [PayType] ([PTID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[ScheduleDetail] ADD CONSTRAINT [FK__ScheduleD__SCHID__787EE5A0] FOREIGN KEY ([SCHID]) REFERENCES [Schedule] ([SCHID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Stuff
-- ----------------------------
ALTER TABLE [dbo].[Stuff] ADD CONSTRAINT [FK__Stuff__STID__693CA210] FOREIGN KEY ([STID]) REFERENCES [StuffType] ([STID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table User
-- ----------------------------
ALTER TABLE [dbo].[User] ADD CONSTRAINT [FK__User__EID__2739D489] FOREIGN KEY ([EID]) REFERENCES [Employee] ([EID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table WriteBack
-- ----------------------------
ALTER TABLE [dbo].[WriteBack] ADD CONSTRAINT [FK__WriteBack__WFID__6477ECF3] FOREIGN KEY ([WFID]) REFERENCES [WriteOff] ([WFID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table WriteOff
-- ----------------------------
ALTER TABLE [dbo].[WriteOff] ADD CONSTRAINT [FK__WriteOff__PawnID__797309D9] FOREIGN KEY ([PawnID]) REFERENCES [PawnContract] ([PawnID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

