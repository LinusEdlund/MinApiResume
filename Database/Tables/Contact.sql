CREATE TABLE [dbo].[Contact]
(
  [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Email] NVARCHAR(100) NOT NULL, 
    [Phone] NVARCHAR(50) NOT NULL, 
    [GitHub] NVARCHAR(100) NOT NULL, 
    [LinkedIn] NVARCHAR(100) NOT NULL, 
    [PersonId] INT NOT NULL, 
    CONSTRAINT [FK_Contacts_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id])
)
