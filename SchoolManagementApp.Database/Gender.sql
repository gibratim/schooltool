CREATE TABLE [dbo].[Gender](
       [GenderId]		[int] IDENTITY (1,1) NOT NULL,
       [Name]			[varchar] (30) NOT NULL,
	   [CreatedBy]		[NVARCHAR](255) NULL,
	   [UpdatedBy]		[NVARCHAR](255) NULL,
	   [DeletedBy]		[NVARCHAR](255) NULL,
	   [CreatedOn]		[datetime] NULL,
	   [TimeStamp]		[datetime] NULL,
	   [Deleted]        BIT NOT NULL,
	   [DeletedOn]      DATETIME NULL,
	   
	   CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED ([GenderId] ASC),
)
GO
ALTER TABLE [dbo].[Gender] ADD CONSTRAINT [DF_Gender_Deleted]     DEFAULT ((0)) FOR [Deleted]