CREATE PROCEDURE [dbo].[spStack_GetAll]

AS

begin
  select [Id], [Language] from Stack;
end
