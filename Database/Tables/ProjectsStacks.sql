CREATE TABLE [dbo].[ProjectsStacks]
(
  [ProjectId] INT NOT NULL , 
    [StackId] INT NOT NULL, 
    CONSTRAINT [FK_ProjectsStacks_Project] FOREIGN KEY ([ProjectId]) REFERENCES [Project]([Id]), 
    CONSTRAINT [FK_ProjectsStacks_Stack] FOREIGN KEY ([StackId]) REFERENCES [Stack]([Id])
)
