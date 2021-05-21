CREATE TABLE [dbo].[Bookings] (
    [Id]           INT      IDENTITY (1, 1) NOT NULL,
    [RoomId]       INT      NOT NULL,
    [StatusId]     INT      NOT NULL,
    [CheckInDate]  DATETIME NOT NULL,
    [CheckoutDate] DATETIME NOT NULL,
    CONSTRAINT [PK_Bookings] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Bookings_BookingStatuses] FOREIGN KEY ([StatusId]) REFERENCES [dbo].[BookingStatuses] ([Id]),
    CONSTRAINT [FK_Bookings_Rooms] FOREIGN KEY ([RoomId]) REFERENCES [dbo].[Rooms] ([Number])
);

