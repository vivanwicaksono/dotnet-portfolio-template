using VivanPortfolio.Constants;
using VivanPortfolio.Infrastructure;
using VivanPortfolio.Models;

namespace VivanPortfolio.Repositories;

public class PortfolioRepository : IPortfolioRepository
{
    public Profile GetProfile() =>
        JsonDataLoader.Load<Profile>(DataFileNames.Profile);

    public List<Experience> GetExperiences() =>
        JsonDataLoader.Load<List<Experience>>(DataFileNames.Experiences);

    public List<SkillGroup> GetSkillGroups() =>
        JsonDataLoader.Load<List<SkillGroup>>(DataFileNames.SkillGroups);

    public List<Education> GetEducation() =>
        JsonDataLoader.Load<List<Education>>(DataFileNames.Education);

    public List<Testimonial> GetTestimonials() =>
        JsonDataLoader.Load<List<Testimonial>>(DataFileNames.Testimonials);

    public List<Certification> GetCertifications() =>
        JsonDataLoader.Load<List<Certification>>(DataFileNames.Certifications);

    public List<SectionSetting> GetSectionSettings() =>
        JsonDataLoader.Load<List<SectionSetting>>(DataFileNames.SectionSettings, "Settings");

    public FieldSettings GetFieldSettings() =>
        JsonDataLoader.Load<FieldSettings>(DataFileNames.FieldSettings, "Settings");

    public TitleSettings GetTitleSettings() =>
        JsonDataLoader.Load<TitleSettings>(DataFileNames.TitleSettings, "Settings");
}
