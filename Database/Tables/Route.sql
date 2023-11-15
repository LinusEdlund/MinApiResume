CREATE TABLE [dbo].[Route]
(
  [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Description] NVARCHAR(100) NULL, 
    [URL] NVARCHAR(200) NOT NULL, 
    [PersonId] INT NOT NULL, 
    CONSTRAINT [FK_Routes_Person] FOREIGN KEY (PersonId) REFERENCES [Person]([Id]) 
)
