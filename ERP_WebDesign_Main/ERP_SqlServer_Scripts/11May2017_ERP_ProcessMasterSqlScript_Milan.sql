USE [ERP_DB]
GO
/****** Object:  Table [dbo].[tbl_ProductionUnitMaster]    Script Date: 05/11/2017 08:15:46 ******/
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
/****** Object:  Table [dbo].[tbl_ProcessMaster]    Script Date: 05/11/2017 08:15:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Create_ProductionUnit]    Script Date: 05/11/2017 08:15:47 ******/
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
/****** Object:  StoredProcedure [dbo].[Get_AllSites]    Script Date: 05/11/2017 08:15:47 ******/
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
/****** Object:  StoredProcedure [dbo].[Update_Process]    Script Date: 05/11/2017 08:15:47 ******/
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
/****** Object:  StoredProcedure [dbo].[Get_AllProcesses]    Script Date: 05/11/2017 08:15:47 ******/
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
/****** Object:  StoredProcedure [dbo].[Create_Process]    Script Date: 05/11/2017 08:15:47 ******/
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
/****** Object:  StoredProcedure [dbo].[Get_ProcessByID]    Script Date: 05/11/2017 08:15:47 ******/
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
/****** Object:  ForeignKey [FK_tbl_ProcessMaster_tbl_ProductionUnitMaster]    Script Date: 05/11/2017 08:15:46 ******/
ALTER TABLE [dbo].[tbl_ProcessMaster]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ProcessMaster_tbl_ProductionUnitMaster] FOREIGN KEY([Site])
REFERENCES [dbo].[tbl_ProductionUnitMaster] ([Site])
GO
ALTER TABLE [dbo].[tbl_ProcessMaster] CHECK CONSTRAINT [FK_tbl_ProcessMaster_tbl_ProductionUnitMaster]
GO
