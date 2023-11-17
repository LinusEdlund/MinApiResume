using DataAccess.Models;

namespace DataAccess.Data.Interfaces;
public interface IProjectData
{
    Task<IEnumerable<PersonModel>> GetProjects();
}