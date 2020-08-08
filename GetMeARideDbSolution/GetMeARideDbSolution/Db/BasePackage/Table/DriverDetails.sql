CREATE TABLE [dbo].[DriverDetails]
(
	[DriverId]				INT            IDENTITY (1, 1) NOT NULL,
	[CabId]				INT			   NOT NULL,
    [DriverName]			NVARCHAR (60)  NOT NULL,
    [ContactNumber]         NVARCHAR (MAX) NULL,
    [Gender]				NVARCHAR (100) NULL,
    [CabNumber]				NVARCHAR (50)  NULL,
    [DriverLicense]			NVARCHAR (60)  NOT NULL,
    [Position]				NVARCHAR (25)  NULL,
    [ArrivalTime]           NVARCHAR (35)  NULL,
    [Status]				BIT            NOT NULL,
    [Created_Date]			DATETIME       NOT NULL, 
	CONSTRAINT [PK__DriverDetails] PRIMARY KEY CLUSTERED ([DriverId] ASC),
	CONSTRAINT [FK__DriverDetails_CabDetails_31EC6D26] FOREIGN KEY ([DriverId]) REFERENCES [dbo].[DriverDetails] ([CabId])
)
