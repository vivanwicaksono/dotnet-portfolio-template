namespace VivanPortfolio.Models;

public class SeoSettings
{
    public string SiteUrl { get; set; } = "";
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string Keywords { get; set; } = "";
    public string Author { get; set; } = "";
    public string OgImage { get; set; } = "";
    public string OgType { get; set; } = "website";
    public string TwitterCard { get; set; } = "summary_large_image";
    public string TwitterHandle { get; set; } = "";
    public string Robots { get; set; } = "index, follow";
    public SeoSitemapSettings Sitemap { get; set; } = new();
    public SeoSchemaSettings Schema { get; set; } = new();
}

public class SeoSitemapSettings
{
    public bool Enabled { get; set; } = true;
    public string Changefreq { get; set; } = "weekly";
    public double Priority { get; set; } = 0.8;
}

public class SeoSchemaSettings
{
    public bool Enabled { get; set; } = true;
}
