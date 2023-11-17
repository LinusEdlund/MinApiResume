CREATE PROCEDURE [dbo].[spExperience_GetAll]

AS

begin
  select [Id], [Title], [WorkPlace], [Range], [Responsibilities], [PersonId] 
  from Experience;
end
