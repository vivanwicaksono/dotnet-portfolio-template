using Microsoft.AspNetCore.Mvc;
using VivanPortfolio.Services;

namespace VivanPortfolio.Controllers;

public class HomeController(IPortfolioService portfolioService) : Controller
{
    public IActionResult Index()
    {
        var viewModel = portfolioService.GetPortfolioViewModel();
        ViewData["SectionSettings"] = viewModel.SectionSettings;
        return View(viewModel);
    }
}
