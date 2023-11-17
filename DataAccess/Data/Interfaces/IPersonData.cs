using DataAccess.Models;

namespace DataAccess.Data.Interfaces;
public interface IPersonData
{
    Task<IEnumerable<PersonModel>> GetPeoples();
}