CREATE PROCEDURE [dbo].[spPerson_GetAll]

AS
begin
  select [Id], [Name], [Surname], [Age] from Person;

end