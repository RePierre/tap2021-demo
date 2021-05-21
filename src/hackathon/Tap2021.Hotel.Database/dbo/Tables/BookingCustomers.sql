CREATE TABLE [dbo].[BookingCustomers] (
    [Id]             UNIQUEIDENTIFIER CONSTRAINT [DF_BookingCustomers_Id] DEFAULT (newid()) NOT NULL,
    [BookingId]      INT              NOT NULL,
    [CustomerId]     UNIQUEIDENTIFIER NOT NULL,
    [AgeCategoryId]  INT              NOT NULL,
    [IsMainCustomer] BIT              NOT NULL,
    CONSTRAINT [PK_BookingCustomers] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_BookingCustomers_AgeCategories] FOREIGN KEY ([AgeCategoryId]) REFERENCES [dbo].[AgeCategories] ([Id]),
    CONSTRAINT [FK_BookingCustomers_Bookings] FOREIGN KEY ([BookingId]) REFERENCES [dbo].[Bookings] ([Id]),
    CONSTRAINT [FK_BookingCustomers_Customers] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([Id])
);

