CREATE TABLE [Employees] (
    [Id] int NOT NULL IDENTITY,
    [FullName] nvarchar(30) NOT NULL,
    [Position] nvarchar(30) NOT NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [Rooms] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(80) NOT NULL,
    [Description] nvarchar(300) NULL,
    [Capacity] int NOT NULL,
    [Available] bit NOT NULL,
    CONSTRAINT [PK_Rooms] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [Reservations] (
    [Id] int NOT NULL IDENTITY,
    [ReservationDate] nvarchar(80) NOT NULL,
    [ReservedById] int NULL,
    [RoomId] int NOT NULL,
    CONSTRAINT [PK_Reservations] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Reservations_Employees_ReservedById] FOREIGN KEY ([ReservedById]) REFERENCES [Employees] ([Id]),
    CONSTRAINT [FK_Reservations_Rooms_RoomId] FOREIGN KEY ([RoomId]) REFERENCES [Rooms] ([Id]) ON DELETE CASCADE
);
GO


CREATE TABLE [Assistants] (
    [Id] int NOT NULL IDENTITY,
    [ReservationId] int NOT NULL,
    [EmployeeId] int NOT NULL,
    [Assisted] bit NOT NULL,
    CONSTRAINT [PK_Assistants] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Assistants_Employees_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Assistants_Reservations_ReservationId] FOREIGN KEY ([ReservationId]) REFERENCES [Reservations] ([Id]) ON DELETE CASCADE
);
GO


CREATE INDEX [IX_Assistants_EmployeeId] ON [Assistants] ([EmployeeId]);
GO


CREATE INDEX [IX_Assistants_ReservationId] ON [Assistants] ([ReservationId]);
GO


CREATE INDEX [IX_Reservations_ReservedById] ON [Reservations] ([ReservedById]);
GO


CREATE INDEX [IX_Reservations_RoomId] ON [Reservations] ([RoomId]);
GO


