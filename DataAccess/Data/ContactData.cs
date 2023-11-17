

using DataAccess.Data.Interfaces;
using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;
public class ContactData : IContactData
{
  private readonly ISqlDataAccess _data;

  public ContactData(ISqlDataAccess data)
  {
    _data = data;
  }

  public async Task<IEnumerable<PersonModel>> GetAllPeoplesContacts()
  {
    var peoples = await _data.LoadData<PersonModel, dynamic>("spPerson_GetAll", new { });

    var contacts = await _data.LoadData<ContactModel, dynamic>("spContact_GetAll", new { });

    foreach (var p in peoples)
    {
      p.Contacts = contacts.Where(x => x.PersonId == p.Id).ToList();
    }

    return peoples;
  }
}
