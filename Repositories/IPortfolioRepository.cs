using VivanPortfolio.Models;

namespace VivanPortfolio.Repositories;

public interface IPortfolioRepository
{
    Profile GetProfile();
    List<Experience> GetExperiences();
    List<SkillGroup> GetSkillGroups();
    List<Education> GetEducation();
    List<Testimonial> GetTestimonials();
}
