namespace VivanPortfolio.Models;

public class PortfolioViewModel
{
    public Profile Profile { get; set; } = new();
    public List<Experience> Experiences { get; set; } = new();
    public List<SkillGroup> SkillGroups { get; set; } = new();
    public List<Education> Education { get; set; } = new();
    public List<Testimonial> Testimonials { get; set; } = new();
    public List<Certification> Certifications { get; set; } = new();
    public List<SectionSetting> SectionSettings { get; set; } = new();
    public FieldSettings FieldSettings { get; set; } = new();
    public TitleSettings TitleSettings { get; set; } = new();
}
