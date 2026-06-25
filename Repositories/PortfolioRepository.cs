using VivanPortfolio.Infrastructure;
using VivanPortfolio.Models;

namespace VivanPortfolio.Repositories;

public class PortfolioRepository : IPortfolioRepository
{
    public Profile GetProfile() =>
        JsonDataLoader.Load<Profile>("Profile.json");

    public List<Experience> GetExperiences() =>
        JsonDataLoader.Load<List<Experience>>("Experiences.json");

    public List<SkillGroup> GetSkillGroups() =>
        JsonDataLoader.Load<List<SkillGroup>>("SkillGroups.json");

    public List<Education> GetEducation() =>
        JsonDataLoader.Load<List<Education>>("Education.json");

    public List<Testimonial> GetTestimonials() =>
        JsonDataLoader.Load<List<Testimonial>>("Testimonials.json");

    public List<Certification> GetCertifications() =>
        JsonDataLoader.Load<List<Certification>>("Certifications.json");

    public List<SectionSetting> GetSectionSettings() =>
        JsonDataLoader.Load<List<SectionSetting>>("SectionSettings.json", "Settings");

    public FieldSettings GetFieldSettings() =>
        JsonDataLoader.Load<FieldSettings>("FieldSettings.json", "Settings");

    public TitleSettings GetTitleSettings() =>
        JsonDataLoader.Load<TitleSettings>("TitleSettings.json", "Settings");
}
