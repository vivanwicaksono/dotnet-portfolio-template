namespace VivanPortfolio.Models;

public class FieldSettings
{
    public HeroFields Hero { get; set; } = new();
    public AboutFields About { get; set; } = new();
    public ExperienceFields Experience { get; set; } = new();
    public SkillsFields Skills { get; set; } = new();
    public EducationFields Education { get; set; } = new();
    public TestimonialsFields Testimonials { get; set; } = new();
    public ContactFields Contact { get; set; } = new();
}

public class HeroFields
{
    public bool Name { get; set; } = true;
    public bool Title { get; set; } = true;
    public bool Location { get; set; } = true;
    public bool OpenToOpportunities { get; set; } = true;
}

public class AboutFields
{
    public bool Summary { get; set; } = true;
    public bool Email { get; set; } = true;
    public bool Location { get; set; } = true;
    public bool LinkedIn { get; set; } = true;
    public bool GitHub { get; set; } = true;
    public bool Languages { get; set; } = true;
}

public class ExperienceFields
{
    public bool Company { get; set; } = true;
    public bool Role { get; set; } = true;
    public bool Period { get; set; } = true;
    public bool CurrentBadge { get; set; } = true;
    public bool ProjectName { get; set; } = true;
    public bool ProjectDescription { get; set; } = true;
    public bool ProjectHighlights { get; set; } = true;
    public bool ProjectTechnologies { get; set; } = true;
}

public class SkillsFields
{
    public bool Icon { get; set; } = true;
    public bool Category { get; set; } = true;
    public bool SkillTags { get; set; } = true;
}

public class EducationFields
{
    public bool Institution { get; set; } = true;
    public bool Degree { get; set; } = true;
    public bool Period { get; set; } = true;
    public bool Location { get; set; } = true;
    public bool Gpa { get; set; } = true;
}

public class TestimonialsFields
{
    public bool Quote { get; set; } = true;
    public bool Author { get; set; } = true;
    public bool AuthorRole { get; set; } = true;
}

public class ContactFields
{
    public bool Email { get; set; } = true;
    public bool LinkedIn { get; set; } = true;
}
