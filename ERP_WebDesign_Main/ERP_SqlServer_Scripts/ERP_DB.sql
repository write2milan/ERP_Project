USE [master]
GO
/****** Object:  Database [ERP_DB]    Script Date: 08/17/2017 07:48:10 ******/
CREATE DATABASE [ERP_DB] ON  PRIMARY 
( NAME = N'ERP_DB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\ERP_DB.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ERP_DB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\ERP_DB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ERP_DB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ERP_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ERP_DB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [ERP_DB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [ERP_DB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [ERP_DB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [ERP_DB] SET ARITHABORT OFF
GO
ALTER DATABASE [ERP_DB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [ERP_DB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [ERP_DB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [ERP_DB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [ERP_DB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [ERP_DB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [ERP_DB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [ERP_DB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [ERP_DB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [ERP_DB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [ERP_DB] SET  DISABLE_BROKER
GO
ALTER DATABASE [ERP_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [ERP_DB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [ERP_DB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [ERP_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [ERP_DB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [ERP_DB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [ERP_DB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [ERP_DB] SET  READ_WRITE
GO
ALTER DATABASE [ERP_DB] SET RECOVERY SIMPLE
GO
ALTER DATABASE [ERP_DB] SET  MULTI_USER
GO
ALTER DATABASE [ERP_DB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [ERP_DB] SET DB_CHAINING OFF
GO
USE [ERP_DB]
GO
/****** Object:  Table [dbo].[tbl_Rack]    Script Date: 08/17/2017 07:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Rack](
	[RackID] [nvarchar](50) NOT NULL,
	[RackCode] [nvarchar](50) NULL,
	[RackDisplayName] [nvarchar](200) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[ModifiedDateTime] [datetime] NULL,
 CONSTRAINT [PK_Rack] PRIMARY KEY CLUSTERED 
(
	[RackID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_ProductMaster]    Script Date: 08/17/2017 07:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ProductMaster](
	[ProductID] [nvarchar](50) NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[ProductDesc] [nvarchar](500) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[ModifiedDateTime] [datetime] NULL,
 CONSTRAINT [PK_ProductID] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_ProductionUnitMaster]    Script Date: 08/17/2017 07:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ProductionUnitMaster](
	[Site] [nvarchar](100) NOT NULL,
	[Location] [nvarchar](500) NULL,
	[Address] [nvarchar](500) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[ModifiedDateTime] [datetime] NULL,
 CONSTRAINT [PK_Site] PRIMARY KEY CLUSTERED 
(
	[Site] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_User]    Script Date: 08/17/2017 07:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_User](
	[USERNAME] [nvarchar](50) NOT NULL,
	[PASSWORD] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[USERNAME] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ToolMaster]    Script Date: 08/17/2017 07:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ToolMaster](
	[ToolID] [nvarchar](50) NOT NULL,
	[ToolName] [nvarchar](50) NULL,
	[ToolDesc] [nvarchar](100) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[ModifiedDateTime] [datetime] NULL,
 CONSTRAINT [PK_tbl_ToolMaster] PRIMARY KEY CLUSTERED 
(
	[ToolID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Groups]    Script Date: 08/17/2017 07:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Groups](
	[GroupID] [nvarchar](50) NOT NULL,
	[GroupCode] [nvarchar](50) NULL,
	[GroupDisplayName] [nvarchar](200) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[ModifiedDateTime] [datetime] NULL,
 CONSTRAINT [PK_GroupID] PRIMARY KEY CLUSTERED 
(
	[GroupID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_ExceptionLogger]    Script Date: 08/17/2017 07:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ExceptionLogger](
	[EXCEPTIONID] [int] IDENTITY(1,1) NOT NULL,
	[EXCEPTIONMESSAGE] [varchar](max) NULL,
	[EXCEPTIONSTACKTRACE] [varchar](max) NULL,
	[EXCEPTIONSOURCE] [varchar](max) NULL,
	[LOGTIME] [datetime] NULL,
	[USERID] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[EXCEPTIONID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_ShiftMaster]    Script Date: 08/17/2017 07:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ShiftMaster](
	[ShiftID] [nvarchar](50) NOT NULL,
	[ShiftName] [nvarchar](100) NULL,
	[ShiftStartTime] [datetime] NULL,
	[ShiftEndTime] [datetime] NULL,
	[ShiftDesc] [nvarchar](500) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[ModifiedDateTime] [datetime] NULL,
 CONSTRAINT [PK_ShiftID] PRIMARY KEY CLUSTERED 
(
	[ShiftID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_MachineMaster]    Script Date: 08/17/2017 07:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_MachineMaster](
	[MachineID] [nvarchar](50) NOT NULL,
	[MachineName] [nvarchar](50) NULL,
	[MachineDesc] [nvarchar](500) NULL,
	[InstallDate] [date] NULL,
	[MCLife] [nvarchar](50) NULL,
	[WarrantyPeriod] [nvarchar](50) NULL,
	[OilRequired] [nvarchar](50) NULL,
	[PowerRequired] [nvarchar](50) NULL,
	[StandardOutputQTY] [nvarchar](50) NULL,
	[StandardOutputUnit] [nchar](10) NULL,
	[StandardRunningTime] [nchar](10) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[ModifiedDateTime] [datetime] NULL,
 CONSTRAINT [PK_tbl_MachineMaster] PRIMARY KEY CLUSTERED 
(
	[MachineID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_LabourMaster]    Script Date: 08/17/2017 07:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_LabourMaster](
	[LabourID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](500) NOT NULL,
	[Contact] [nvarchar](50) NULL,
	[DailyWage] [nvarchar](50) NULL,
	[DailyWageFrequency] [nchar](10) NULL,
	[OTHourlyRate] [nchar](10) NULL,
	[SkillSet] [nvarchar](50) NULL,
	[StandardWorkingHr] [nchar](10) NULL,
	[Shift] [nchar](10) NULL,
	[Role] [nchar](10) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[ModifiedDateTime] [datetime] NULL,
 CONSTRAINT [PK_tbl_LabourMaster] PRIMARY KEY CLUSTERED 
(
	[LabourID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Items]    Script Date: 08/17/2017 07:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Items](
	[ItemID] [nvarchar](50) NOT NULL,
	[ItemCode] [nvarchar](50) NULL,
	[ItemDisplayName] [nvarchar](200) NULL,
	[GroupID] [nvarchar](50) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[ModifiedDateTime] [datetime] NULL,
 CONSTRAINT [PK_ItemID] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_SalesOrder]    Script Date: 08/17/2017 07:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_SalesOrder](
	[SalesOrderID] [nvarchar](50) NOT NULL,
	[SalesOrderDate] [datetime] NULL,
	[DeliveryDate] [datetime] NULL,
	[Period] [int] NULL,
	[Qty] [int] NULL,
	[OrderStatus] [nvarchar](50) NULL,
	[ProductID] [nvarchar](50) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[ModifiedDateTime] [datetime] NULL,
 CONSTRAINT [PK_SalesOrderID] PRIMARY KEY CLUSTERED 
(
	[SalesOrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Get_ToolByID]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_ToolByID]
	@Id BIGINT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [dbo].[tbl_ToolMaster]
	WHERE [ToolID]=@Id
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Tool]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_Tool] 
	-- Add the parameters for the stored procedure here
	@ToolID nvarchar(50)=null,
    @ToolName nvarchar(50)=null,
    @ToolDesc nvarchar(100)=null,     
    @ModifiedBy varchar(50)=null,
    @ModifiedDateTime datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   DECLARE @intErrorCode INT
    -- Insert statements for procedure here
	BEGIN TRAN
		-- Insert statements for procedure here
		UPDATE [dbo].[tbl_ToolMaster] SET 
	   
       [ToolName] = @ToolName
      ,[ToolDesc] = @ToolDesc     
      ,[ModifiedBy] =@ModifiedBy
      ,[ModifiedDateTime] =@ModifiedDateTime
		WHERE [ToolID] = @ToolID
		
		SELECT @intErrorCode = @@ERROR
		IF (@intErrorCode <> 0) GOTO ERR_HANDLER
    COMMIT TRAN

RETURN 0

ERR_HANDLER:
PRINT 'Unexpected error occurred!'
ROLLBACK TRAN
RETURN 1
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Machine]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_Machine]
	-- Add the parameters for the stored procedure here
	 @MachineID Nvarchar(50)
	,@MachineName Nvarchar(50)=null
	,@MachineDesc Nvarchar(500)=null
	,@InstallDate date=null
	,@MCLife nvarchar(50)=null
	,@WarrantyPeriod nvarchar(50)=null
	,@OilRequired nvarchar(50)=null
	,@PowerRequired nvarchar(50)=null
	,@StandardOutputQTY nvarchar(50)=null
	,@StandardOutputUnit nchar(10)=null
	,@StandardRunningTime nchar(10)=null		
	,@ModifiedBy Nvarchar(50)=null
	,@ModifiedDateTime datetime=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @intErrorCode INT
    -- Insert statements for procedure here
	BEGIN TRAN
		-- Insert statements for procedure here
		UPDATE [dbo].[tbl_MachineMaster] SET 
		[MachineName]=@MachineName, 
		[MachineDesc]=@MachineDesc, 
		[InstallDate]=@InstallDate, 
		[MCLife]=@MCLife, 
		[WarrantyPeriod]=@WarrantyPeriod, 
		[OilRequired]=@OilRequired, 
		[PowerRequired]=@PowerRequired, 
		[StandardOutputQTY]=@StandardOutputQTY, 
		[StandardOutputUnit]=@StandardOutputUnit, 
		[StandardRunningTime]=@StandardRunningTime, 		
		[ModifiedBy]=@ModifiedBy, 
		[ModifiedDateTime]=@ModifiedDateTime 
		WHERE [MachineID] = @MachineID
		
		SELECT @intErrorCode = @@ERROR
		IF (@intErrorCode <> 0) GOTO ERR_HANDLER
    COMMIT TRAN

RETURN 0

ERR_HANDLER:
PRINT 'Unexpected error occurred!'
ROLLBACK TRAN
RETURN 1
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Labour]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_Labour]
		   @LabourID nvarchar(50),
		   @Name nvarchar(50)=null,
           @Address nvarchar(500)=null,
           @Contact nvarchar(50)=null,
           @DailyWage nvarchar(50)=null,
           @DailyWageFrequency nchar(10)=null,
           @OTHourlyRate nchar(10)=null,
           @SkillSet nvarchar(50)=null,
           @StandardWorkingHr nchar(10)=null,
           @Shift nchar(10)=null,
           @Role nchar(10)=null,           
           @ModifiedBy varchar(50)=null,
           @ModifiedDateTime datetime=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   DECLARE @intErrorCode INT
    -- Insert statements for procedure here
	BEGIN TRAN
		-- Insert statements for procedure here
		UPDATE [dbo].[tbl_LabourMaster] SET 
	   
       [Name] = @Name,
       [Address] = @Address,
       [Contact] = @Contact, 
       [DailyWage] = @DailyWage,
       [DailyWageFrequency] = @DailyWageFrequency, 
       [OTHourlyRate] = @OTHourlyRate,
       [SkillSet] = @SkillSet,
       [StandardWorkingHr] = @StandardWorkingHr, 
       [Shift] = @Shift, 
       [Role] = @Role,      
       [ModifiedBy] = @ModifiedBy, 
       [ModifiedDateTime] = @ModifiedDateTime
		WHERE [LabourID] = @LabourID
		
		SELECT @intErrorCode = @@ERROR
		IF (@intErrorCode <> 0) GOTO ERR_HANDLER
    COMMIT TRAN

RETURN 0

ERR_HANDLER:
PRINT 'Unexpected error occurred!'
ROLLBACK TRAN
RETURN 1
END
GO
/****** Object:  StoredProcedure [dbo].[Update_ProductionUnit]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_ProductionUnit]
	-- Add the parameters for the stored procedure here
	@Site nvarchar(100),
	@Location nvarchar(500)=null,
	@Address nvarchar(500)=null,
	@ModifiedBy varchar(50)=null,
	@ModifiedDateTime datetime=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @intErrorCode INT
	BEGIN TRAN
		-- Insert statements for procedure here
		UPDATE [dbo].tbl_ProductionUnitMaster SET 
		[Location]=@Location,
		[Address]=@Address,		
		[ModifiedBy]=@ModifiedBy,
		[ModifiedDateTime]=@ModifiedDateTime
		WHERE [Site] = @Site
		
		SELECT @intErrorCode = @@ERROR
		IF (@intErrorCode <> 0) GOTO ERR_HANDLER
    COMMIT TRAN

RETURN 0

ERR_HANDLER:
PRINT 'Unexpected error occurred!'
ROLLBACK TRAN
RETURN 1
END
GO
/****** Object:  Table [dbo].[tbl_ProcessMaster]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ProcessMaster](
	[ProcessID] [nvarchar](50) NOT NULL,
	[ProcessName] [nvarchar](50) NOT NULL,
	[ProcessDesc] [nvarchar](500) NULL,
	[Site] [nvarchar](100) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[ModifiedDateTime] [datetime] NULL,
 CONSTRAINT [PK_ProcessId] PRIMARY KEY CLUSTERED 
(
	[ProcessID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Get_MachineByID]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_MachineByID] 
	-- Add the parameters for the stored procedure here
	@Id BIGINT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [dbo].tbl_MachineMaster
	WHERE MachineID=@Id
END
GO
/****** Object:  StoredProcedure [dbo].[Get_LabourByID]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_LabourByID]
	-- Add the parameters for the stored procedure here
	@Id BIGINT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [dbo].[tbl_LabourMaster] 
	WHERE [LabourID]=@Id
END
GO
/****** Object:  StoredProcedure [dbo].[Get_AllTools]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_AllTools]  
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from dbo.tbl_ToolMaster
END
GO
/****** Object:  StoredProcedure [dbo].[Get_AllSites]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_AllSites]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Site FROM [dbo].tbl_ProductionUnitMaster
END
GO
/****** Object:  StoredProcedure [dbo].[Get_AllProductionUnits]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_AllProductionUnits]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [dbo].tbl_ProductionUnitMaster
END
GO
/****** Object:  StoredProcedure [dbo].[Get_ProductionUnitByID]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_ProductionUnitByID] 
	-- Add the parameters for the stored procedure here
	@Site nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [dbo].tbl_ProductionUnitMaster
	WHERE [Site]=@Site
END
GO
/****** Object:  StoredProcedure [dbo].[Get_AllMachines]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_AllMachines] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from dbo.tbl_MachineMaster
END
GO
/****** Object:  StoredProcedure [dbo].[Get_AllLabours]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_AllLabours] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from dbo.tbl_LabourMaster
END
GO
/****** Object:  StoredProcedure [dbo].[Create_Tool]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Create_Tool]
	-- Add the parameters for the stored procedure here
	
           @ToolName nvarchar(50)=null,
           @ToolDesc nvarchar(100)=null,
           @CreatedBy varchar(50)=null,
           @ModifiedBy varchar(50)=null,
           @CreatedDateTime datetime=null,           
           @ModifiedDateTime datetime=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   DECLARE @Id bigint;
	DECLARE @intErrorCode INT
	 
	SET @Id = ISNULL(((SELECT MAX(ToolID) FROM [tbl_ToolMaster])+1),'1')
	BEGIN TRAN
		-- Insert statements for procedure here
		INSERT INTO [dbo].[tbl_ToolMaster]
		(	[ToolID]
           ,[ToolName]
           ,[ToolDesc]
           ,[CreatedBy]
           ,[CreatedDateTime]
           ,[ModifiedBy]
           ,[ModifiedDateTime])
		VALUES
		(  @Id,
		   @ToolName, 
           @ToolDesc,
           @CreatedBy,
           @CreatedDateTime,
           @ModifiedBy,
           @ModifiedDateTime)
		
		SELECT @intErrorCode = @@ERROR
		IF (@intErrorCode <> 0) GOTO ERR_HANDLER
    COMMIT TRAN

RETURN 0

ERR_HANDLER:
PRINT 'Unexpected error occurred!'
ROLLBACK TRAN
RETURN 1
END
GO
/****** Object:  StoredProcedure [dbo].[Create_Machine]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Create_Machine] 
	-- Add the parameters for the stored procedure here
	 @MachineName Nvarchar(50)=null
	,@MachineDesc Nvarchar(500)=null
	,@InstallDate date=null
	,@MCLife nvarchar(50)=null
	,@WarrantyPeriod nvarchar(50)=null
	,@OilRequired nvarchar(50)=null
	,@PowerRequired nvarchar(50)=null
	,@StandardOutputQTY nvarchar(50)=null
	,@StandardOutputUnit nchar(10)=null
	,@StandardRunningTime nchar(10)=null	
	,@CreatedBy Nvarchar(50)=null
	,@ModifiedBy Nvarchar(50)=null
	,@CreatedDateTime datetime=null
	,@ModifiedDateTime datetime=null
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @Id bigint;
	DECLARE @intErrorCode INT
	 
	SET @Id = ISNULL(((SELECT MAX(MachineID) FROM [tbl_MachineMaster])+1),'1')
	BEGIN TRAN
		-- Insert statements for procedure here
		INSERT INTO [dbo].[tbl_MachineMaster] ([MachineID],[MachineName],[MachineDesc],[InstallDate],[MCLife],[WarrantyPeriod],[OilRequired],[PowerRequired],[StandardOutputQTY],[StandardOutputUnit],[StandardRunningTime],[CreatedBy],[ModifiedBy],[CreatedDateTime],[ModifiedDateTime])
		VALUES(@Id,@MachineName ,@MachineDesc ,@InstallDate ,@MCLife ,@WarrantyPeriod ,@OilRequired ,@PowerRequired ,@StandardOutputQTY ,@StandardOutputUnit ,@StandardRunningTime ,@CreatedBy ,@ModifiedBy ,@CreatedDateTime ,@ModifiedDateTime )
		
		SELECT @intErrorCode = @@ERROR
		IF (@intErrorCode <> 0) GOTO ERR_HANDLER
    COMMIT TRAN

RETURN 0

ERR_HANDLER:
PRINT 'Unexpected error occurred!'
ROLLBACK TRAN
RETURN 1
END
GO
/****** Object:  StoredProcedure [dbo].[Create_Labour]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Create_Labour] 
		   
           @Name nvarchar(50)=null,
           @Address nvarchar(500)=null,
           @Contact nvarchar(50)=null,
           @DailyWage nvarchar(50)=null,
           @DailyWageFrequency nchar(10)=null,
           @OTHourlyRate nchar(10)=null,
           @SkillSet nvarchar(50)=null,
           @StandardWorkingHr nchar(10)=null,
           @Shift nchar(10)=null,
           @Role nchar(10)=null,
           @CreatedBy varchar(50)=null,           
           @ModifiedBy varchar(50)=null,
           @CreatedDateTime datetime=null,
           @ModifiedDateTime datetime=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DECLARE @Id bigint;
	DECLARE @intErrorCode INT
	 
	SET @Id = ISNULL(((SELECT MAX(LabourID) FROM [tbl_LabourMaster])+1),'1')
	BEGIN TRAN
		-- Insert statements for procedure here
		INSERT INTO [ERP_DB].[dbo].[tbl_LabourMaster]
           ([LabourID]
           ,[Name]
           ,[Address]
           ,[Contact]
           ,[DailyWage]
           ,[DailyWageFrequency]
           ,[OTHourlyRate]
           ,[SkillSet]
           ,[StandardWorkingHr]
           ,[Shift]
           ,[Role]
           ,[CreatedBy]
           ,[CreatedDateTime]
           ,[ModifiedBy]
           ,[ModifiedDateTime])
     VALUES
           (@Id,
			@Name, 				
			@Address, 			
			@Contact, 			
			@DailyWage, 			
			@DailyWageFrequency,
			@OTHourlyRate, 		
			@SkillSet, 			
			@StandardWorkingHr, 
			@Shift, 				
			@Role, 				
			@CreatedBy, 			
			@CreatedDateTime, 	
			@ModifiedBy, 			
			@ModifiedDateTime )
		
		SELECT @intErrorCode = @@ERROR
		IF (@intErrorCode <> 0) GOTO ERR_HANDLER
    COMMIT TRAN

RETURN 0

ERR_HANDLER:
PRINT 'Unexpected error occurred!'
ROLLBACK TRAN
RETURN 1
END
GO
/****** Object:  StoredProcedure [dbo].[Create_ProductionUnit]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Create_ProductionUnit] 
	-- Add the parameters for the stored procedure here
	 @Site Nvarchar(100)
	,@Location Nvarchar(500)=null
	,@Address Nvarchar(500)=null
	,@CreatedBy Nvarchar(50)=null
	,@ModifiedBy Nvarchar(50)=null
	,@CreatedDateTime datetime=null
	,@ModifiedDateTime datetime=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;	
	DECLARE @intErrorCode INT	 
	
	BEGIN TRAN
		-- Insert statements for procedure here
		INSERT INTO [dbo].[tbl_ProductionUnitMaster] ([Site],[Location],[Address],[CreatedBy],[ModifiedBy],[CreatedDateTime],[ModifiedDateTime])
		VALUES(@Site,@Location,@Address,@CreatedBy,@ModifiedBy,@CreatedDateTime,@ModifiedDateTime)
		
		SELECT @intErrorCode = @@ERROR
		IF (@intErrorCode <> 0) GOTO ERR_HANDLER
    COMMIT TRAN

RETURN 0

ERR_HANDLER:
PRINT 'Unexpected error occurred!'
ROLLBACK TRAN
RETURN 1
	
END
GO
/****** Object:  StoredProcedure [dbo].[Create_Process]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Create_Process]
	-- Add the parameters for the stored procedure here
	 @ProcessName Nvarchar(50)=null
	,@ProcessDesc Nvarchar(500)=null
	,@Site Nvarchar(100)=null
	,@CreatedBy Nvarchar(50)=null
	,@ModifiedBy Nvarchar(50)=null
	,@CreatedDateTime datetime=null
	,@ModifiedDateTime datetime=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	DECLARE @Id bigint;
	DECLARE @intErrorCode INT
	 
	SET @Id = ISNULL(((SELECT MAX(ProcessID) FROM [tbl_ProcessMaster])+1),'1')
	BEGIN TRAN
		-- Insert statements for procedure here
		INSERT INTO [dbo].[tbl_ProcessMaster] ([ProcessID],[ProcessName],[ProcessDesc],[Site],[CreatedBy],[ModifiedBy],[CreatedDateTime],[ModifiedDateTime])
		VALUES(@Id,@ProcessName,@ProcessDesc,@Site,@CreatedBy,@ModifiedBy,@CreatedDateTime,@ModifiedDateTime)
		
		SELECT @intErrorCode = @@ERROR
		IF (@intErrorCode <> 0) GOTO ERR_HANDLER
    COMMIT TRAN

RETURN 0

ERR_HANDLER:
PRINT 'Unexpected error occurred!'
ROLLBACK TRAN
RETURN 1
	
END
GO
/****** Object:  StoredProcedure [dbo].[Get_ProcessByID]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_ProcessByID] 
	-- Add the parameters for the stored procedure here
	@Id BIGINT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [dbo].tbl_ProcessMaster
	WHERE ProcessID=@Id
END
GO
/****** Object:  StoredProcedure [dbo].[Get_AllProcesses]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_AllProcesses]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [dbo].tbl_ProcessMaster
END
GO
/****** Object:  Table [dbo].[tbl_SubProcess]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_SubProcess](
	[SubProcessID] [nvarchar](50) NOT NULL,
	[SubProcessName] [nvarchar](100) NULL,
	[SubProcessDesc] [nvarchar](500) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[ModifiedDateTime] [datetime] NULL,
	[ProcessID] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_SubProcess] PRIMARY KEY CLUSTERED 
(
	[SubProcessID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Specification]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Specification](
	[SpecificationID] [nvarchar](50) NOT NULL,
	[SpecificationCode] [nvarchar](50) NULL,
	[SpecificationDisplayName] [nvarchar](200) NULL,
	[ItemID] [nvarchar](50) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[ModifiedDateTime] [datetime] NULL,
	[GroupID] [nvarchar](50) NULL,
 CONSTRAINT [PK_Specification] PRIMARY KEY CLUSTERED 
(
	[SpecificationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Update_Process]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_Process]
	-- Add the parameters for the stored procedure here
	 @ProcessID Nvarchar(50)
	,@ProcessName Nvarchar(50)=null
	,@ProcessDesc Nvarchar(500)=null
	,@Site Nvarchar(100)=null
	,@ModifiedBy Nvarchar(50)=null
	,@ModifiedDateTime datetime=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @intErrorCode INT
    -- Insert statements for procedure here
	BEGIN TRAN
		-- Insert statements for procedure here
		UPDATE [dbo].[tbl_ProcessMaster] SET 
		[ProcessName]=@ProcessName,
		[ProcessDesc]=@ProcessDesc,
		[Site]=@Site,
		[ModifiedBy]=@ModifiedBy,
		[ModifiedDateTime]=@ModifiedDateTime
		WHERE [ProcessID] = @ProcessID
		
		SELECT @intErrorCode = @@ERROR
		IF (@intErrorCode <> 0) GOTO ERR_HANDLER
    COMMIT TRAN

RETURN 0

ERR_HANDLER:
PRINT 'Unexpected error occurred!'
ROLLBACK TRAN
RETURN 1
END
GO
/****** Object:  StoredProcedure [dbo].[Update_SubProcess]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_SubProcess] 
	-- Add the parameters for the stored procedure here
	
	@SubProcessID Nvarchar(50),
	@SubProcessName Nvarchar(50)=null,
	@SubProcessDesc nvarchar(500)=null	
	,@ModifiedBy Nvarchar(50)=null	
	,@ModifiedDateTime datetime=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @intErrorCode INT
	BEGIN TRAN
    -- Insert statements for procedure here
	UPDATE [dbo].[tbl_SubProcess] SET 
		[SubProcessName]=@SubProcessName,		
		[SubProcessDesc]=@SubProcessDesc,
		[ModifiedBy]=@ModifiedBy,
		[ModifiedDateTime]=@ModifiedDateTime
		WHERE [SubProcessID] = @SubProcessID
	SELECT @intErrorCode = @@ERROR
		IF (@intErrorCode <> 0) GOTO ERR_HANDLER
    COMMIT TRAN

RETURN 0

ERR_HANDLER:
PRINT 'Unexpected error occurred!'
ROLLBACK TRAN
RETURN 1

	
END
GO
/****** Object:  StoredProcedure [dbo].[Get_SubProcessByID]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_SubProcessByID]
	-- Add the parameters for the stored procedure here
	@SubProcessID nvarchar(50)
AS	
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [dbo].tbl_SubProcess
		WHERE [SubProcessID]=@SubProcessID
END
GO
/****** Object:  Table [dbo].[tbl_Codification]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Codification](
	[CodificationID] [nvarchar](50) NOT NULL,
	[CodificationCode] [nvarchar](200) NOT NULL,
	[ItemID] [nvarchar](50) NULL,
	[GroupID] [nvarchar](50) NULL,
	[SpecificationID] [nvarchar](50) NULL,
	[RackID] [nvarchar](50) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[ModifiedDateTime] [datetime] NULL,
 CONSTRAINT [PK_Codification] PRIMARY KEY CLUSTERED 
(
	[CodificationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Get_AllSubProcess]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_AllSubProcess] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	--SELECT s.*,p.ProcessName FROM [dbo].tbl_SubProcess s left outer join tbl_ProcessMaster p
	--on s.ProcessID=p.ProcessID
	select * from tbl_SubProcess
END
GO
/****** Object:  StoredProcedure [dbo].[Create_SubProcess]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Create_SubProcess] 
	-- Add the parameters for the stored procedure here
	@SubProcessName Nvarchar(50)=null,
	@SubProcessDesc nvarchar(500)=null
	--,@ProcessID Nvarchar(50)=null
	,@CreatedBy Nvarchar(50)=null
	,@ModifiedBy Nvarchar(50)=null
	,@CreatedDateTime datetime=null
	,@ModifiedDateTime datetime=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @Id bigint;
	DECLARE @intErrorCode INT
	
	SET @Id = ISNULL(((SELECT MAX(SubProcessID) FROM [tbl_SubProcess])+1),'1')
	BEGIN TRAN
		-- Insert statements for procedure here
		INSERT INTO [dbo].[tbl_SubProcess] ([SubProcessID],[SubProcessName],[SubProcessDesc],[CreatedBy],[ModifiedBy],[CreatedDateTime],[ModifiedDateTime])
		VALUES(@Id,@SubProcessName,@SubProcessDesc,@CreatedBy,@ModifiedBy,@CreatedDateTime,@ModifiedDateTime)
		
		SELECT @intErrorCode = @@ERROR
		IF (@intErrorCode <> 0) GOTO ERR_HANDLER
    COMMIT TRAN

RETURN 0

ERR_HANDLER:
PRINT 'Unexpected error occurred!'
ROLLBACK TRAN
RETURN 1
END
GO
/****** Object:  StoredProcedure [dbo].[ERP_DB_SPGetCodificationSearchData]    Script Date: 08/17/2017 07:48:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ERP_DB_SPGetCodificationSearchData]  
(  
 @FILTER XML,  
 @TOTALRECORDCOUNT INT OUTPUT  
)  
AS  
BEGIN  
 SET NOCOUNT ON;  
 DECLARE @CODIFICATIONCODE NVARCHAR(200);  
 DECLARE @PAGENO INT;  
 DECLARE @PAGESIZE INT;  
 DECLARE @SORTFIELD VARCHAR(50);  
 DECLARE @SORTDIR VARCHAR(10);  
 DECLARE @ORDERBY NVARCHAR(200);   
   
 DECLARE @tbl_CODITEMP TABLE (  
      [Id] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,  
      [CodificationID] [nvarchar](50) NOT NULL,  
      [CodificationCode] [nvarchar](200) NOT NULL,  
      [ItemID] [nvarchar](50) NULL,  
      [GroupID] [nvarchar](50) NULL,  
      [SpecificationID] [nvarchar](50) NULL,  
      [RackID] [nvarchar](50) NULL,  
      [CreatedBy] [varchar](50) NULL,  
      [CreatedDateTime] [datetime] NULL,  
      [ModifiedBy] [varchar](50) NULL,  
      [ModifiedDateTime] [datetime] NULL  
      )  
 SELECT   
   @CODIFICATIONCODE = COALESCE(A.B.value('CODIFICATIONCODE[1]','NVARCHAR(200)'),NULL),  
   --@SORTFIELD = COALESCE(A.B.value('SORT[1]','VARCHAR(50)'),'PLNT_CD'),  
   --@SORTDIR = COALESCE(A.B.value('SORTDIR[1]','VARCHAR(10)'),'ASC'),  
   @PAGENO = COALESCE(A.B.value('PAGENO[1]','INT'),1),  
   @PAGESIZE = COALESCE(A.B.value('PAGESIZE[1]','INT'),1)  
   FROM @FILTER.nodes('ROOT') A(B)  
     
  
   
 --SET @ORDERBY = @SORTFIELD + ' ' +@SORTDIR       
   
 INSERT INTO @tbl_CODITEMP([CodificationID],[CodificationCode],[ItemID],[GroupID],[SpecificationID],[RackID],[CreatedBy],[CreatedDateTime],[ModifiedBy],[ModifiedDateTime])  
 SELECT [CodificationID],[CodificationCode],[ItemID],[GroupID],[SpecificationID],[RackID],[CreatedBy],[CreatedDateTime],[ModifiedBy],[ModifiedDateTime]  
 FROM tbl_Codification AS CODI  
 WHERE (@CODIFICATIONCODE IS NULL OR CODI.CodificationCode LIKE @CODIFICATIONCODE + '%' )  
   
   
 SELECT @TOTALRECORDCOUNT = COUNT(1)  FROM @tbl_CODITEMP  
 SELECT * FROM @tbl_CODITEMP WHERE Id BETWEEN ((@PAGENO -1) * @PAGESIZE + 1) AND(@PAGENO * @PAGESIZE)  
   
END
GO
/****** Object:  ForeignKey [FK_ITEMS_GroupID]    Script Date: 08/17/2017 07:48:10 ******/
ALTER TABLE [dbo].[tbl_Items]  WITH CHECK ADD  CONSTRAINT [FK_ITEMS_GroupID] FOREIGN KEY([GroupID])
REFERENCES [dbo].[tbl_Groups] ([GroupID])
GO
ALTER TABLE [dbo].[tbl_Items] CHECK CONSTRAINT [FK_ITEMS_GroupID]
GO
/****** Object:  ForeignKey [FK_SO_ProductID]    Script Date: 08/17/2017 07:48:10 ******/
ALTER TABLE [dbo].[tbl_SalesOrder]  WITH CHECK ADD  CONSTRAINT [FK_SO_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[tbl_ProductMaster] ([ProductID])
GO
ALTER TABLE [dbo].[tbl_SalesOrder] CHECK CONSTRAINT [FK_SO_ProductID]
GO
/****** Object:  ForeignKey [FK_tbl_ProcessMaster_tbl_ProductionUnitMaster]    Script Date: 08/17/2017 07:48:12 ******/
ALTER TABLE [dbo].[tbl_ProcessMaster]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ProcessMaster_tbl_ProductionUnitMaster] FOREIGN KEY([Site])
REFERENCES [dbo].[tbl_ProductionUnitMaster] ([Site])
GO
ALTER TABLE [dbo].[tbl_ProcessMaster] CHECK CONSTRAINT [FK_tbl_ProcessMaster_tbl_ProductionUnitMaster]
GO
/****** Object:  ForeignKey [FK_tbl_SubProcess_tbl_ProcessMaster]    Script Date: 08/17/2017 07:48:12 ******/
ALTER TABLE [dbo].[tbl_SubProcess]  WITH CHECK ADD  CONSTRAINT [FK_tbl_SubProcess_tbl_ProcessMaster] FOREIGN KEY([ProcessID])
REFERENCES [dbo].[tbl_ProcessMaster] ([ProcessID])
GO
ALTER TABLE [dbo].[tbl_SubProcess] CHECK CONSTRAINT [FK_tbl_SubProcess_tbl_ProcessMaster]
GO
/****** Object:  ForeignKey [FK_SPEC_GroupID]    Script Date: 08/17/2017 07:48:12 ******/
ALTER TABLE [dbo].[tbl_Specification]  WITH CHECK ADD  CONSTRAINT [FK_SPEC_GroupID] FOREIGN KEY([GroupID])
REFERENCES [dbo].[tbl_Groups] ([GroupID])
GO
ALTER TABLE [dbo].[tbl_Specification] CHECK CONSTRAINT [FK_SPEC_GroupID]
GO
/****** Object:  ForeignKey [FK_SPEC_ItemID]    Script Date: 08/17/2017 07:48:12 ******/
ALTER TABLE [dbo].[tbl_Specification]  WITH CHECK ADD  CONSTRAINT [FK_SPEC_ItemID] FOREIGN KEY([ItemID])
REFERENCES [dbo].[tbl_Items] ([ItemID])
GO
ALTER TABLE [dbo].[tbl_Specification] CHECK CONSTRAINT [FK_SPEC_ItemID]
GO
/****** Object:  ForeignKey [FK_CODI_GroupID]    Script Date: 08/17/2017 07:48:12 ******/
ALTER TABLE [dbo].[tbl_Codification]  WITH CHECK ADD  CONSTRAINT [FK_CODI_GroupID] FOREIGN KEY([GroupID])
REFERENCES [dbo].[tbl_Groups] ([GroupID])
GO
ALTER TABLE [dbo].[tbl_Codification] CHECK CONSTRAINT [FK_CODI_GroupID]
GO
/****** Object:  ForeignKey [FK_CODI_ItemID]    Script Date: 08/17/2017 07:48:12 ******/
ALTER TABLE [dbo].[tbl_Codification]  WITH CHECK ADD  CONSTRAINT [FK_CODI_ItemID] FOREIGN KEY([ItemID])
REFERENCES [dbo].[tbl_Items] ([ItemID])
GO
ALTER TABLE [dbo].[tbl_Codification] CHECK CONSTRAINT [FK_CODI_ItemID]
GO
/****** Object:  ForeignKey [FK_CODI_RackID]    Script Date: 08/17/2017 07:48:12 ******/
ALTER TABLE [dbo].[tbl_Codification]  WITH CHECK ADD  CONSTRAINT [FK_CODI_RackID] FOREIGN KEY([RackID])
REFERENCES [dbo].[tbl_Rack] ([RackID])
GO
ALTER TABLE [dbo].[tbl_Codification] CHECK CONSTRAINT [FK_CODI_RackID]
GO
/****** Object:  ForeignKey [FK_CODI_SpecificationID]    Script Date: 08/17/2017 07:48:12 ******/
ALTER TABLE [dbo].[tbl_Codification]  WITH CHECK ADD  CONSTRAINT [FK_CODI_SpecificationID] FOREIGN KEY([SpecificationID])
REFERENCES [dbo].[tbl_Specification] ([SpecificationID])
GO
ALTER TABLE [dbo].[tbl_Codification] CHECK CONSTRAINT [FK_CODI_SpecificationID]
GO
