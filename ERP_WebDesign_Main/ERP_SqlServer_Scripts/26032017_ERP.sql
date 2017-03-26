 
GO
/****** Object:  Table [dbo].[tbl_ProductMaster]    Script Date: 03/26/2017 14:00:24 ******/
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
/****** Object:  Table [dbo].[tbl_ProductionUnitMaster]    Script Date: 03/26/2017 14:00:24 ******/
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
/****** Object:  Table [dbo].[tbl_ProcessMaster]    Script Date: 03/26/2017 14:00:24 ******/
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
	[Site] [nvarchar](500) NULL,
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
/****** Object:  Table [dbo].[tbl_ExceptionLogger]    Script Date: 03/26/2017 14:00:24 ******/
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
/****** Object:  Table [dbo].[tbl_User]    Script Date: 03/26/2017 14:00:24 ******/
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
/****** Object:  Table [dbo].[tbl_ShiftMaster]    Script Date: 03/26/2017 14:00:24 ******/
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
/****** Object:  Table [dbo].[tbl_SalesOrder]    Script Date: 03/26/2017 14:00:24 ******/
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
/****** Object:  ForeignKey [FK_SO_ProductID]    Script Date: 03/26/2017 14:00:24 ******/
ALTER TABLE [dbo].[tbl_SalesOrder]  WITH CHECK ADD  CONSTRAINT [FK_SO_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[tbl_ProductMaster] ([ProductID])
GO
ALTER TABLE [dbo].[tbl_SalesOrder] CHECK CONSTRAINT [FK_SO_ProductID]
GO
