CREATE TABLE [dbo].[Stack]
(
  [Id] INT NOT NULL PRIMARY KEY, 
    [Language] NVARCHAR(50) NOT NULL, 
    [ProjectId] INT NOT NULL, 
    CONSTRAINT [FK_Stack_Project] FOREIGN KEY ([ProjectId]) REFERENCES [Project]([Id])
)
