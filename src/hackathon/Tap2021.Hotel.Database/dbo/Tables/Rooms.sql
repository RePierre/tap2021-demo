CREATE TABLE [dbo].[Rooms] (
    [Number]             INT NOT NULL,
    [TypeId]             INT NOT NULL,
    [HasPrivateBathroom] BIT NOT NULL,
    CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED ([Number] ASC),
    CONSTRAINT [FK_Rooms_RoomTypes] FOREIGN KEY ([Number]) REFERENCES [dbo].[RoomTypes] ([Id])
);

