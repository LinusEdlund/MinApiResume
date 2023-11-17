using DataAccess.Models;

namespace DataAccess.Data.Interfaces;
public interface IContactData
{
    Task<IEnumerable<PersonModel>> GetAllPeoplesContacts();
}