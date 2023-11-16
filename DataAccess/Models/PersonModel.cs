

namespace DataAccess.Models;
public class PersonModel
{
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public string Surname { get; set; } = string.Empty;
  public int Age { get; set; }
  public List<ContactModel> Contacts { get; set; } = new();
  public List<ExperienceModel> Experiences { get; set; } = new();
  public List<ProjectModel> Projects { get; set; } = new();
  public List<RouteModel> Routes { get; set; } = new();

}
