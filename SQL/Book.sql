CREATE TABLE [dbo].[BookData] (
    [ISBN]       CHAR (10)       NOT NULL,
    [CategoryID] INT             NOT NULL,
    [Title]      VARCHAR (80)    NULL,
    [Author]     VARCHAR (255)   NULL,
    [Price]      DECIMAL (10, 2) NULL,
    [SupplierId] INT             NULL,
    [Year]       NCHAR (4)       NULL,
    [Edition]    NCHAR (2)       NOT NULL,
    [Publisher]  NVARCHAR (50)   NULL,
    [Quantity]   INT             NOT NULL,
    [Description] VARCHAR (255)  NOT NULL,
    CONSTRAINT [PK_BookData] PRIMARY KEY CLUSTERED ([ISBN] ASC),
    CONSTRAINT [FK_BookData_Category] FOREIGN KEY ([CategoryID]) REFERENCES [dbo].[Category] ([CategoryID]),
    CONSTRAINT [FK_BookData_Supplier] FOREIGN KEY ([SupplierId]) REFERENCES [dbo].[Supplier] ([SupplierId])
);
