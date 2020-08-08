CREATE TABLE [dbo].[CabDetails]
(
	[CabId]				INT NOT NULL PRIMARY KEY,
	[ModelName]			NVARCHAR (60)  NOT NULL,
    [Brand]				NVARCHAR (MAX) NULL,
    [Colour]			NVARCHAR (100) NULL,
    [Id]				INT,
    [NoOfPassenger]		NVARCHAR (60)  NOT NULL,
    [Amount]			NVARCHAR (25)  NULL,
    [CreatedOn]         DateTime,
    [UserId]			INT            NOT NULL,
	[ETA]		INT NULL
)
