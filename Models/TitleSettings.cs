namespace VivanPortfolio.Models;

public class TitleSettings
{
    public HeroTitles Hero { get; set; } = new();
    public AboutTitles About { get; set; } = new();
    public SectionLabel Experience { get; set; } = new();
    public SectionLabel Skills { get; set; } = new();
    public SectionLabel Education { get; set; } = new();
    public SectionLabel Testimonials { get; set; } = new();
    public ContactTitles Contact { get; set; } = new();
}

public class SectionLabel
{
    public string Tag { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
}

public class HeroTitles
{
    public string Greeting { get; set; } = string.Empty;
    public string Tagline { get; set; } = string.Empty;
    public string CtaPrimary { get; set; } = string.Empty;
    public string CtaSecondary { get; set; } = string.Empty;
    public string OpenToOpportunities { get; set; } = string.Empty;
}

public class AboutTitles : SectionLabel
{
    public string ExtraText { get; set; } = string.Empty;
    public string Languages { get; set; } = string.Empty;
}

public class ContactTitles : SectionLabel
{
    public string Description { get; set; } = string.Empty;
    public string EmailButton { get; set; } = string.Empty;
    public string LinkedInButton { get; set; } = string.Empty;
}
