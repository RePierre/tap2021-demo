CREATE TABLE [dbo].[Customers] (
    [Id]          UNIQUEIDENTIFIER CONSTRAINT [DF_Customers_Id] DEFAULT (newid()) NOT NULL,
    [IdNo]        VARCHAR (50)     NOT NULL,
    [FirstName]   NVARCHAR (100)   NOT NULL,
    [LastName]    NVARCHAR (100)   NOT NULL,
    [PhoneNumber] VARCHAR (50)     NULL,
    [Email]       VARCHAR (150)    NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Customers]
    ON [dbo].[Customers]([IdNo] ASC);

