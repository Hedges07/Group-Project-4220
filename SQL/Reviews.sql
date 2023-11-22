CREATE TABLE [dbo].[Reviews] (
    [ReviewID]   INT            IDENTITY(1,1) NOT NULL,
    [Rating]     INT            NOT NULL,
    [UserID]     INT            NOT NULL,
    [ISBN]       CHAR (10)      NOT NULL,
    CONSTRAINT [PK_Reviews] PRIMARY KEY CLUSTERED ([ReviewID] ASC),
    CONSTRAINT [FK_Reviews_User] FOREIGN KEY ([UserID]) REFERENCES [dbo].[UserData] ([UserID]),
    CONSTRAINT [FK_Reviews_BookData] FOREIGN KEY ([ISBN]) REFERENCES [dbo].[BookData] ([ISBN])
);