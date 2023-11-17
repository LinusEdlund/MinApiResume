using DataAccess.Models;

namespace DataAccess.Data;
public interface IProjectData
{
  Task<IEnumerable<PersonModel>> GetProjects();
}