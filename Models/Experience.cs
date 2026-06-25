namespace VivanPortfolio.Models;

public class Experience
{
    public string Company { get; set; } = string.Empty;
    public string CompanyLink { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string Period { get; set; } = string.Empty;
    public bool IsCurrent { get; set; }
    public List<Project> Projects { get; set; } = new();
}

public class Project
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> Highlights { get; set; } = new();
    public List<string> Technologies { get; set; } = new();
}
