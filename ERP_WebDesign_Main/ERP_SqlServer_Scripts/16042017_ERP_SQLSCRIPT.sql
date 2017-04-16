/****** Object:  ForeignKey [FK_CODI_GroupID]    Script Date: 04/16/2017 15:13:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_GroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] DROP CONSTRAINT [FK_CODI_GroupID]
GO
/****** Object:  ForeignKey [FK_CODI_ItemID]    Script Date: 04/16/2017 15:13:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_ItemID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] DROP CONSTRAINT [FK_CODI_ItemID]
GO
/****** Object:  ForeignKey [FK_CODI_RackID]    Script Date: 04/16/2017 15:13:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_RackID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] DROP CONSTRAINT [FK_CODI_RackID]
GO
/****** Object:  ForeignKey [FK_CODI_SpecificationID]    Script Date: 04/16/2017 15:13:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_SpecificationID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] DROP CONSTRAINT [FK_CODI_SpecificationID]
GO
/****** Object:  ForeignKey [FK_ITEMS_GroupID]    Script Date: 04/16/2017 15:13:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ITEMS_GroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Items]'))
ALTER TABLE [dbo].[tbl_Items] DROP CONSTRAINT [FK_ITEMS_GroupID]
GO
/****** Object:  ForeignKey [FK_SO_ProductID]    Script Date: 04/16/2017 15:13:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SO_ProductID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_SalesOrder]'))
ALTER TABLE [dbo].[tbl_SalesOrder] DROP CONSTRAINT [FK_SO_ProductID]
GO
/****** Object:  ForeignKey [FK_SPEC_GroupID]    Script Date: 04/16/2017 15:13:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SPEC_GroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Specification]'))
ALTER TABLE [dbo].[tbl_Specification] DROP CONSTRAINT [FK_SPEC_GroupID]
GO
/****** Object:  ForeignKey [FK_SPEC_ItemID]    Script Date: 04/16/2017 15:13:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SPEC_ItemID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Specification]'))
ALTER TABLE [dbo].[tbl_Specification] DROP CONSTRAINT [FK_SPEC_ItemID]
GO
/****** Object:  Table [dbo].[tbl_Codification]    Script Date: 04/16/2017 15:13:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_GroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] DROP CONSTRAINT [FK_CODI_GroupID]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_ItemID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] DROP CONSTRAINT [FK_CODI_ItemID]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_RackID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] DROP CONSTRAINT [FK_CODI_RackID]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_SpecificationID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] DROP CONSTRAINT [FK_CODI_SpecificationID]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Codification]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Codification]
GO
/****** Object:  Table [dbo].[tbl_Specification]    Script Date: 04/16/2017 15:13:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SPEC_GroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Specification]'))
ALTER TABLE [dbo].[tbl_Specification] DROP CONSTRAINT [FK_SPEC_GroupID]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SPEC_ItemID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Specification]'))
ALTER TABLE [dbo].[tbl_Specification] DROP CONSTRAINT [FK_SPEC_ItemID]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Specification]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Specification]
GO
/****** Object:  Table [dbo].[tbl_SalesOrder]    Script Date: 04/16/2017 15:13:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SO_ProductID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_SalesOrder]'))
ALTER TABLE [dbo].[tbl_SalesOrder] DROP CONSTRAINT [FK_SO_ProductID]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_SalesOrder]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_SalesOrder]
GO
/****** Object:  Table [dbo].[tbl_Items]    Script Date: 04/16/2017 15:13:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ITEMS_GroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Items]'))
ALTER TABLE [dbo].[tbl_Items] DROP CONSTRAINT [FK_ITEMS_GroupID]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Items]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Items]
GO
/****** Object:  Table [dbo].[tbl_ProcessMaster]    Script Date: 04/16/2017 15:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_ProcessMaster]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_ProcessMaster]
GO
/****** Object:  Table [dbo].[tbl_ProductionUnitMaster]    Script Date: 04/16/2017 15:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_ProductionUnitMaster]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_ProductionUnitMaster]
GO
/****** Object:  Table [dbo].[tbl_ProductMaster]    Script Date: 04/16/2017 15:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_ProductMaster]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_ProductMaster]
GO
/****** Object:  Table [dbo].[tbl_Rack]    Script Date: 04/16/2017 15:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Rack]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Rack]
GO
/****** Object:  Table [dbo].[tbl_ShiftMaster]    Script Date: 04/16/2017 15:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_ShiftMaster]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_ShiftMaster]
GO
/****** Object:  Table [dbo].[tbl_User]    Script Date: 04/16/2017 15:13:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_User]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_User]
GO
/****** Object:  Table [dbo].[tbl_ExceptionLogger]    Script Date: 04/16/2017 15:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_ExceptionLogger]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_ExceptionLogger]
GO
/****** Object:  Table [dbo].[tbl_Groups]    Script Date: 04/16/2017 15:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Groups]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Groups]
GO
/****** Object:  Table [dbo].[tbl_Groups]    Script Date: 04/16/2017 15:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Groups]') AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_ExceptionLogger]    Script Date: 04/16/2017 15:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_ExceptionLogger]') AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_User]    Script Date: 04/16/2017 15:13:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_User]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_User](
	[USERNAME] [nvarchar](50) NOT NULL,
	[PASSWORD] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[USERNAME] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[tbl_ShiftMaster]    Script Date: 04/16/2017 15:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_ShiftMaster]') AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Rack]    Script Date: 04/16/2017 15:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Rack]') AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_ProductMaster]    Script Date: 04/16/2017 15:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_ProductMaster]') AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_ProductionUnitMaster]    Script Date: 04/16/2017 15:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_ProductionUnitMaster]') AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_ProcessMaster]    Script Date: 04/16/2017 15:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_ProcessMaster]') AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Items]    Script Date: 04/16/2017 15:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Items]') AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_SalesOrder]    Script Date: 04/16/2017 15:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_SalesOrder]') AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Specification]    Script Date: 04/16/2017 15:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Specification]') AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Codification]    Script Date: 04/16/2017 15:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Codification]') AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_CODI_GroupID]    Script Date: 04/16/2017 15:13:52 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_GroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification]  WITH CHECK ADD  CONSTRAINT [FK_CODI_GroupID] FOREIGN KEY([GroupID])
REFERENCES [dbo].[tbl_Groups] ([GroupID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_GroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] CHECK CONSTRAINT [FK_CODI_GroupID]
GO
/****** Object:  ForeignKey [FK_CODI_ItemID]    Script Date: 04/16/2017 15:13:52 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_ItemID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification]  WITH CHECK ADD  CONSTRAINT [FK_CODI_ItemID] FOREIGN KEY([ItemID])
REFERENCES [dbo].[tbl_Items] ([ItemID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_ItemID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] CHECK CONSTRAINT [FK_CODI_ItemID]
GO
/****** Object:  ForeignKey [FK_CODI_RackID]    Script Date: 04/16/2017 15:13:52 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_RackID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification]  WITH CHECK ADD  CONSTRAINT [FK_CODI_RackID] FOREIGN KEY([RackID])
REFERENCES [dbo].[tbl_Rack] ([RackID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_RackID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] CHECK CONSTRAINT [FK_CODI_RackID]
GO
/****** Object:  ForeignKey [FK_CODI_SpecificationID]    Script Date: 04/16/2017 15:13:52 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_SpecificationID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification]  WITH CHECK ADD  CONSTRAINT [FK_CODI_SpecificationID] FOREIGN KEY([SpecificationID])
REFERENCES [dbo].[tbl_Specification] ([SpecificationID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_SpecificationID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] CHECK CONSTRAINT [FK_CODI_SpecificationID]
GO
/****** Object:  ForeignKey [FK_ITEMS_GroupID]    Script Date: 04/16/2017 15:13:52 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ITEMS_GroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Items]'))
ALTER TABLE [dbo].[tbl_Items]  WITH CHECK ADD  CONSTRAINT [FK_ITEMS_GroupID] FOREIGN KEY([GroupID])
REFERENCES [dbo].[tbl_Groups] ([GroupID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ITEMS_GroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Items]'))
ALTER TABLE [dbo].[tbl_Items] CHECK CONSTRAINT [FK_ITEMS_GroupID]
GO
/****** Object:  ForeignKey [FK_SO_ProductID]    Script Date: 04/16/2017 15:13:52 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SO_ProductID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_SalesOrder]'))
ALTER TABLE [dbo].[tbl_SalesOrder]  WITH CHECK ADD  CONSTRAINT [FK_SO_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[tbl_ProductMaster] ([ProductID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SO_ProductID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_SalesOrder]'))
ALTER TABLE [dbo].[tbl_SalesOrder] CHECK CONSTRAINT [FK_SO_ProductID]
GO
/****** Object:  ForeignKey [FK_SPEC_GroupID]    Script Date: 04/16/2017 15:13:52 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SPEC_GroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Specification]'))
ALTER TABLE [dbo].[tbl_Specification]  WITH CHECK ADD  CONSTRAINT [FK_SPEC_GroupID] FOREIGN KEY([GroupID])
REFERENCES [dbo].[tbl_Groups] ([GroupID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SPEC_GroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Specification]'))
ALTER TABLE [dbo].[tbl_Specification] CHECK CONSTRAINT [FK_SPEC_GroupID]
GO
/****** Object:  ForeignKey [FK_SPEC_ItemID]    Script Date: 04/16/2017 15:13:52 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SPEC_ItemID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Specification]'))
ALTER TABLE [dbo].[tbl_Specification]  WITH CHECK ADD  CONSTRAINT [FK_SPEC_ItemID] FOREIGN KEY([ItemID])
REFERENCES [dbo].[tbl_Items] ([ItemID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SPEC_ItemID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Specification]'))
ALTER TABLE [dbo].[tbl_Specification] CHECK CONSTRAINT [FK_SPEC_ItemID]
GO
