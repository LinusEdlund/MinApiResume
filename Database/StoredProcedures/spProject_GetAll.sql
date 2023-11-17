CREATE PROCEDURE [dbo].[spProject_GetAll]

AS
begin
  select [Id], [Name], [Description], [Live], [Repo], [PersonId] 
  from Project;
end
