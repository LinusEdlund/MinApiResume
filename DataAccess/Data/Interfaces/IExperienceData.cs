using DataAccess.Models;

namespace DataAccess.Data.Interfaces;
public interface IExperienceData
{
    Task<IEnumerable<PersonModel>> GetExperience();
}