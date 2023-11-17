using DataAccess.Data;

namespace MininalAPI;

public static class Api
{
  public static void ConfigureApi(this WebApplication app)
  {
    app.MapGet("/Contacts", GetContacts);
    app.MapGet("/Experience", GetExperience);
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

  private static async Task<IResult> GetExperience(IExperienceData data)
  {
    try
    {
      return Results.Ok(await data.GetExperience());
    }
    catch (Exception ex)
    {
      return Results.Problem(ex.Message);
    }
  }
}
