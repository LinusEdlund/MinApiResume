using DataAccess.Data.Interfaces;

namespace MininalAPI;

public static class Api
{
  public static void ConfigureApi(this WebApplication app)
  {
    app.MapGet("/Contacts", GetContacts);
    app.MapGet("/Experience", GetExperience);
    app.MapGet("/Project", GetProject);
    app.MapGet("/People", GetPeople);
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

  private static async Task<IResult> GetProject(IProjectData data)
  {
    try
    {
      return Results.Ok(await data.GetProjects());
    }
    catch (Exception ex)
    {
      return Results.Problem(ex.Message);
    }
  }

  private static async Task<IResult> GetPeople(IPersonData data)
  {
    try
    {
      return Results.Ok(await data.GetPeoples());
    }
    catch (Exception ex)
    {
      return Results.Problem(ex.Message);
    }
  }
}
