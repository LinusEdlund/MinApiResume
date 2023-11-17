namespace DataAccess.Models;

public class ProjectModel
{
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public string Description { get; set; } = string.Empty;
  public string Repo { get; set; } = string.Empty;
  public string Live { get; set; } = string.Empty;
  public int PersonId { get; set; }
  public List<StackModel> Stacks { get; set; } = new();
}