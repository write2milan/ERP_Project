USE [ERP_DB]
GO
/****** Object:  StoredProcedure [dbo].[Update_ProductionUnit]    Script Date: 05/12/2017 07:45:01 ******/
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
/****** Object:  StoredProcedure [dbo].[Get_ProductionUnitByID]    Script Date: 05/12/2017 07:45:01 ******/
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
/****** Object:  StoredProcedure [dbo].[Get_AllProductionUnits]    Script Date: 05/12/2017 07:45:01 ******/
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
