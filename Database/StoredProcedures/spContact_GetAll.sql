CREATE PROCEDURE [dbo].[spContact_GetAll]

AS
begin
  select [Id], [Email], [Phone], [GitHub], [LinkedIn], [PersonId] from Contact;
end
