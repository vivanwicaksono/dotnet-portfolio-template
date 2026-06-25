# Portfolio Website Template — ASP.NET Core MVC

A clean, responsive personal portfolio website built with **ASP.NET Core MVC** (.NET 9), following a **Controller → Service → Repository** layered architecture. All content is driven by JSON files — no code changes needed to update your profile, toggle sections, or rearrange the layout.

## Features

- Single-page layout with 9 configurable sections: Hero, About, Experience, Skills, Education, Certifications, Projects, Testimonials, Contact
- Each section can be independently enabled/disabled and reordered via a single JSON file
- Individual fields within each section can be shown or hidden without touching any code
- All UI text — titles, taglines, button labels, footer copy — is centralised in one JSON file
- Professional design: Inter font, indigo accent, frosted-glass navbar, smooth scroll
- Fully responsive (mobile-first with Bootstrap 5)
- Active nav highlighting via IntersectionObserver
- SEO-ready: Open Graph, Twitter Card, JSON-LD Person Schema, auto-generated sitemap and robots.txt
- Freelance platform support: LinkedIn, GitHub, Upwork, Fiverr, Toptal, Freelancer, Guru, PeoplePerHour

## Tech Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core MVC (.NET 9) |
| Language | C# 13 |
| View Engine | Razor (`.cshtml`) |
| Styling | Bootstrap 5 + custom CSS (CSS custom properties) |
| Icons | Bootstrap Icons 1.11 |
| Font | Inter (Google Fonts) |
| JS | Vanilla JS (scroll effects, active nav, mobile menu) |

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- A terminal (PowerShell, bash, or any shell)

## How to Build & Run

**1. Clone the repository**

```bash
git clone https://github.com/vivanwicaksono/portofolio-template.git
cd portofolio-template
```

**2. Restore dependencies**

```bash
dotnet restore
```

**3. Run in development**

```bash
dotnet run
```

The site will be available at `http://localhost:5241` (or check the console output for the exact URL).

**4. Build for production**

```bash
dotnet publish -c Release -o ./publish
```

## Customising the Content

All portfolio content and display settings live in JSON files under `Resources/` — no recompilation needed for any content or layout change.

See **[configuration.md](configuration.md)** for the full guide covering:

- Enabling/disabling sections and changing their order
- Showing or hiding individual fields within each section
- Updating all UI text (titles, taglines, button labels, footer)
- Replacing the profile photo, hero background, favicon, and touch icon
- Editing your profile, experience, skills, education, and other data
- Configuring SEO metadata, Open Graph, Twitter Card, sitemap, and JSON-LD schema

## License

MIT
