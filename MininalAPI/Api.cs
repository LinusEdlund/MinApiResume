using DataAccess.Data;

namespace MininalAPI;

public static class Api
{
  public static void ConfigureApi(this WebApplication app)
  {
    app.MapGet("/Contacts", GetContacts);
  }

  private static async Task<IResult> GetContacts(IContactData data)
  {
    try
    {
      return Results.Ok(await data.GetAllPeoplesContacts());
    }
    catch (Exception ex)
    {
      return Results.Problem(ex.Message);
    }
  }
}
