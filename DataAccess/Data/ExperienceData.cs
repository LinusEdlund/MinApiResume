

using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;
public class ExperienceData : IExperienceData
{
  private readonly ISqlDataAccess _data;

  public ExperienceData(ISqlDataAccess data)
  {
    _data = data;
  }

  public async Task<IEnumerable<PersonModel>> GetExperience()
  {
    var peoples = await _data.LoadData<PersonModel, dynamic>("spPerson_GetAll", new { });

    var experiences = await _data.LoadData<ExperienceModel, dynamic>("spExperience_GetAll", new { });

    foreach (var p in peoples)
    {
      p.Experiences = experiences.Where(x => x.PersonId == p.Id).ToList();
    }

    return peoples;
  }
}
