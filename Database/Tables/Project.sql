CREATE TABLE [dbo].[Project]
(
  [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(50) NOT NULL, 
    [Live] NVARCHAR(50) NULL, 
    [Repo] NVARCHAR(50) NULL, 
    [PersonId] INT NOT NULL, 
    CONSTRAINT [FK_Projects_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id])
)
