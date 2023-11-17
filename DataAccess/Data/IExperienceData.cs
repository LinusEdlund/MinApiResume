using DataAccess.Models;

namespace DataAccess.Data;
public interface IExperienceData
{
  Task<IEnumerable<PersonModel>> GetExperience();
}