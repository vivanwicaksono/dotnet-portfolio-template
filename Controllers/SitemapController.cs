using Microsoft.AspNetCore.Mvc;
using System.Text;
using VivanPortfolio.Repositories;

namespace VivanPortfolio.Controllers;

public class SitemapController(IPortfolioRepository repository) : Controller
{
    public IActionResult Index()
    {
        var seo = repository.GetSeoSettings();
        if (!seo.Sitemap.Enabled)
            return NotFound();

        var sections = repository.GetSectionSettings();
        var baseUrl = seo.SiteUrl.TrimEnd('/');
        var changefreq = seo.Sitemap.Changefreq;
        var priority = seo.Sitemap.Priority;
        var lastMod = DateTime.UtcNow.ToString("yyyy-MM-dd");

        var sb = new StringBuilder();
        sb.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
        sb.AppendLine("<urlset xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">");

        sb.AppendLine("  <url>");
        sb.AppendLine($"    <loc>{baseUrl}/</loc>");
        sb.AppendLine($"    <lastmod>{lastMod}</lastmod>");
        sb.AppendLine($"    <changefreq>{changefreq}</changefreq>");
        sb.AppendLine("    <priority>1.0</priority>");
        sb.AppendLine("  </url>");

        foreach (var section in sections.Where(s => s.Enabled && s.Key != "hero").OrderBy(s => s.Order))
        {
            sb.AppendLine("  <url>");
            sb.AppendLine($"    <loc>{baseUrl}/#{section.Key}</loc>");
            sb.AppendLine($"    <lastmod>{lastMod}</lastmod>");
            sb.AppendLine($"    <changefreq>{changefreq}</changefreq>");
            sb.AppendLine($"    <priority>{priority.ToString("F1", System.Globalization.CultureInfo.InvariantCulture)}</priority>");
            sb.AppendLine("  </url>");
        }

        sb.Append("</urlset>");

        return Content(sb.ToString(), "application/xml", Encoding.UTF8);
    }

    public IActionResult Robots()
    {
        var seo = repository.GetSeoSettings();
        var baseUrl = seo.SiteUrl.TrimEnd('/');

        var sb = new StringBuilder();
        sb.AppendLine("User-agent: *");
        sb.AppendLine("Allow: /");
        if (seo.Sitemap.Enabled && !string.IsNullOrEmpty(baseUrl))
        {
            sb.AppendLine($"Sitemap: {baseUrl}/sitemap.xml");
        }

        return Content(sb.ToString(), "text/plain", Encoding.UTF8);
    }
}
