CREATE TABLE [dbo].[Experience]
(
  [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(50) NULL, 
    [WorkPlace] NVARCHAR(50) NULL, 
    [Range] NVARCHAR(50) NULL, 
    [Responsibilities] NVARCHAR(50) NULL, 
    [PersonId] INT NULL, 
    CONSTRAINT [FK_Experience_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id])
)
