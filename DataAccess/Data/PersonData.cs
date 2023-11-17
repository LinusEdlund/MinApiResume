

using DataAccess.Data.Interfaces;
using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;
public class PersonData : IPersonData
{
  private readonly ISqlDataAccess _data;
  private readonly IProjectData _projectData;

  public PersonData(ISqlDataAccess data, IProjectData projectData)
  {
    _data = data;
    _projectData = projectData;
  }


  public async Task<IEnumerable<PersonModel>> GetPeoples()
  {
    var person = await _projectData.GetProjects();
    var contacts = await _data.LoadData<ContactModel, dynamic>("spContact_GetAll", new { });
    var experiences = await _data.LoadData<ExperienceModel, dynamic>("spExperience_GetAll", new { });


    foreach (var p in person)
    {
      p.Contacts = contacts.Where(x => x.PersonId == p.Id).ToList();
      p.Experiences = experiences.Where(x => x.PersonId == p.Id).ToList();
    }
    return person;
  }

}
