using VivanPortfolio.Models;
using VivanPortfolio.Repositories;

namespace VivanPortfolio.Services;

public class PortfolioService(IPortfolioRepository repository) : IPortfolioService
{
    public PortfolioViewModel GetPortfolioViewModel() => new()
    {
        Profile = repository.GetProfile(),
        Experiences = repository.GetExperiences(),
        SkillGroups = repository.GetSkillGroups(),
        Education = repository.GetEducation(),
        Testimonials = repository.GetTestimonials(),
        Certifications = repository.GetCertifications(),
        PersonalProjects = repository.GetPersonalProjects(),
        SectionSettings = repository.GetSectionSettings(),
        FieldSettings = repository.GetFieldSettings(),
        TitleSettings = repository.GetTitleSettings()
    };
}
