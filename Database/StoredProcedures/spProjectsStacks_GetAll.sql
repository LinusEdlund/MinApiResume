CREATE PROCEDURE [dbo].[spProjectsStacks_GetAll]

AS
begin
  select [ProjectId], [StackId] from ProjectsStacks;
end