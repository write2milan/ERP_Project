/****** Object:  ForeignKey [FK_CODI_GroupID]    Script Date: 04/08/2017 00:13:34 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_GroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] DROP CONSTRAINT [FK_CODI_GroupID]
GO
/****** Object:  ForeignKey [FK_CODI_ItemID]    Script Date: 04/08/2017 00:13:34 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_ItemID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] DROP CONSTRAINT [FK_CODI_ItemID]
GO
/****** Object:  ForeignKey [FK_CODI_RackID]    Script Date: 04/08/2017 00:13:34 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_RackID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] DROP CONSTRAINT [FK_CODI_RackID]
GO
/****** Object:  ForeignKey [FK_CODI_SpecificationID]    Script Date: 04/08/2017 00:13:34 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_SpecificationID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] DROP CONSTRAINT [FK_CODI_SpecificationID]
GO
/****** Object:  ForeignKey [FK_ITEMS_GroupID]    Script Date: 04/08/2017 00:13:34 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ITEMS_GroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Items]'))
ALTER TABLE [dbo].[tbl_Items] DROP CONSTRAINT [FK_ITEMS_GroupID]
GO
/****** Object:  ForeignKey [FK_SPEC_ItemID]    Script Date: 04/08/2017 00:13:34 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SPEC_ItemID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Specification]'))
ALTER TABLE [dbo].[tbl_Specification] DROP CONSTRAINT [FK_SPEC_ItemID]
GO
/****** Object:  Table [dbo].[tbl_Codification]    Script Date: 04/08/2017 00:13:33 ******/
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
/****** Object:  Table [dbo].[tbl_Specification]    Script Date: 04/08/2017 00:13:34 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SPEC_ItemID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Specification]'))
ALTER TABLE [dbo].[tbl_Specification] DROP CONSTRAINT [FK_SPEC_ItemID]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Specification]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Specification]
GO
/****** Object:  Table [dbo].[tbl_Items]    Script Date: 04/08/2017 00:13:34 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ITEMS_GroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Items]'))
ALTER TABLE [dbo].[tbl_Items] DROP CONSTRAINT [FK_ITEMS_GroupID]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Items]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Items]
GO
/****** Object:  Table [dbo].[tbl_Rack]    Script Date: 04/08/2017 00:13:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Rack]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Rack]
GO
/****** Object:  Table [dbo].[tbl_Groups]    Script Date: 04/08/2017 00:13:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Groups]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Groups]
GO
/****** Object:  Table [dbo].[tbl_Groups]    Script Date: 04/08/2017 00:13:34 ******/
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
/****** Object:  Table [dbo].[tbl_Rack]    Script Date: 04/08/2017 00:13:34 ******/
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
/****** Object:  Table [dbo].[tbl_Items]    Script Date: 04/08/2017 00:13:34 ******/
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
/****** Object:  Table [dbo].[tbl_Specification]    Script Date: 04/08/2017 00:13:34 ******/
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
 CONSTRAINT [PK_Specification] PRIMARY KEY CLUSTERED 
(
	[SpecificationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Codification]    Script Date: 04/08/2017 00:13:33 ******/
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
/****** Object:  ForeignKey [FK_CODI_GroupID]    Script Date: 04/08/2017 00:13:34 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_GroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification]  WITH CHECK ADD  CONSTRAINT [FK_CODI_GroupID] FOREIGN KEY([GroupID])
REFERENCES [dbo].[tbl_Groups] ([GroupID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_GroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] CHECK CONSTRAINT [FK_CODI_GroupID]
GO
/****** Object:  ForeignKey [FK_CODI_ItemID]    Script Date: 04/08/2017 00:13:34 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_ItemID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification]  WITH CHECK ADD  CONSTRAINT [FK_CODI_ItemID] FOREIGN KEY([ItemID])
REFERENCES [dbo].[tbl_Items] ([ItemID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_ItemID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] CHECK CONSTRAINT [FK_CODI_ItemID]
GO
/****** Object:  ForeignKey [FK_CODI_RackID]    Script Date: 04/08/2017 00:13:34 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_RackID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification]  WITH CHECK ADD  CONSTRAINT [FK_CODI_RackID] FOREIGN KEY([RackID])
REFERENCES [dbo].[tbl_Rack] ([RackID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_RackID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] CHECK CONSTRAINT [FK_CODI_RackID]
GO
/****** Object:  ForeignKey [FK_CODI_SpecificationID]    Script Date: 04/08/2017 00:13:34 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_SpecificationID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification]  WITH CHECK ADD  CONSTRAINT [FK_CODI_SpecificationID] FOREIGN KEY([SpecificationID])
REFERENCES [dbo].[tbl_Specification] ([SpecificationID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CODI_SpecificationID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Codification]'))
ALTER TABLE [dbo].[tbl_Codification] CHECK CONSTRAINT [FK_CODI_SpecificationID]
GO
/****** Object:  ForeignKey [FK_ITEMS_GroupID]    Script Date: 04/08/2017 00:13:34 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ITEMS_GroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Items]'))
ALTER TABLE [dbo].[tbl_Items]  WITH CHECK ADD  CONSTRAINT [FK_ITEMS_GroupID] FOREIGN KEY([GroupID])
REFERENCES [dbo].[tbl_Groups] ([GroupID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ITEMS_GroupID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Items]'))
ALTER TABLE [dbo].[tbl_Items] CHECK CONSTRAINT [FK_ITEMS_GroupID]
GO
/****** Object:  ForeignKey [FK_SPEC_ItemID]    Script Date: 04/08/2017 00:13:34 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SPEC_ItemID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Specification]'))
ALTER TABLE [dbo].[tbl_Specification]  WITH CHECK ADD  CONSTRAINT [FK_SPEC_ItemID] FOREIGN KEY([ItemID])
REFERENCES [dbo].[tbl_Items] ([ItemID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SPEC_ItemID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Specification]'))
ALTER TABLE [dbo].[tbl_Specification] CHECK CONSTRAINT [FK_SPEC_ItemID]
GO
