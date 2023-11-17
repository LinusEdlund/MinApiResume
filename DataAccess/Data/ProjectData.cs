

using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;
public class ProjectData : IProjectData
{
  private readonly ISqlDataAccess _data;

  public ProjectData(ISqlDataAccess data)
  {
    _data = data;
  }

  public async Task<IEnumerable<PersonModel>> GetProjects()
  {
    var peoples = await _data.LoadData<PersonModel, dynamic>("spPerson_GetAll", new { });

    var stacks = await _data.LoadData<StackModel, dynamic>("spStack_GetAll", new { });

    var projects = await _data.LoadData<ProjectModel, dynamic>("spProject_GetAll", new { });

    var projectStacks = await _data.LoadData<ProjectStacksModel, dynamic>("spProjectsStacks_GetAll", new { });


    foreach (var p in peoples)
    {
      p.Projects = projects.Where(pr => pr.PersonId == p.Id).ToList();

      foreach (var project in p.Projects)
      {
        var projectStackIds = projectStacks
            .Where(ps => ps.ProjectId == project.Id)
            .Select(ps => ps.StackId);

        project.Stacks = stacks.Where(s => projectStackIds.Contains(s.Id)).ToList();
      }
    }

    return peoples;

  }

}
