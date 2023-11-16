using DataAccess.Models;

namespace DataAccess.Data;
public interface IContactData
{
  Task<IEnumerable<PersonModel>> GetAllPeoplesContacts();
}