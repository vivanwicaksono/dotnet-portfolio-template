namespace VivanPortfolio.Models;

public class TitleSettings
{
    public LayoutTitles Layout { get; set; } = new();
    public HeroTitles Hero { get; set; } = new();
    public AboutTitles About { get; set; } = new();
    public SectionLabel Experience { get; set; } = new();
    public SectionLabel Skills { get; set; } = new();
    public SectionLabel Education { get; set; } = new();
    public SectionLabel Testimonials { get; set; } = new();
    public ContactTitles Contact { get; set; } = new();
    public SectionLabel Certifications { get; set; } = new();
    public SectionLabel Projects { get; set; } = new();
}

public class LayoutTitles
{
    public string BrandName { get; set; } = string.Empty;
    public string FooterText { get; set; } = string.Empty;
    public string FooterCredit { get; set; } = string.Empty;
    public string Favicon { get; set; } = string.Empty;
    public string TouchIcon { get; set; } = string.Empty;
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
    public string ProfileImage { get; set; } = string.Empty;
    public string HeroBackground { get; set; } = string.Empty;
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
    public string FiverrButton { get; set; } = string.Empty;
    public string UpworkButton { get; set; } = string.Empty;
    public string ToptalButton { get; set; } = string.Empty;
    public string FreelancerButton { get; set; } = string.Empty;
    public string GuruButton { get; set; } = string.Empty;
    public string PeoplePerHourButton { get; set; } = string.Empty;
}
