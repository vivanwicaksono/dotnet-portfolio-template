namespace VivanPortfolio.Models;

public class SkillGroup
{
    public string Category { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public List<string> Skills { get; set; } = new();
}
