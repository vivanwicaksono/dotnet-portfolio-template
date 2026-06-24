# Portfolio Website Template — ASP.NET Core MVC

A clean, responsive personal portfolio website built with **ASP.NET Core MVC** following a **Controller → Service → Repository** layered architecture. All content is hardcoded in the repository layer, making it straightforward to swap in a real data source later.

## Features

- Single-page layout: Hero, About, Experience (timeline), Skills, Education, Testimonials, Contact
- Professional but relaxed design — Inter font, indigo accent, frosted-glass navbar, smooth scroll
- Fully responsive (mobile-first with Bootstrap 5)
- Active nav highlighting via IntersectionObserver
- Contact buttons wired to email and LinkedIn

## Tech Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core MVC (.NET 9) |
| Language | C# 13 |
| View Engine | Razor (`.cshtml`) |
| Styling | Bootstrap 5 + custom CSS (CSS custom properties) |
| Icons | Bootstrap Icons 1.11 |
| Font | Inter (Google Fonts) |
| JS | Vanilla JS (scroll effects, active nav) |

## Project Structure

```
VivanPortfolio/
├── Controllers/
│   └── HomeController.cs          # Thin controller — delegates to service
├── Services/
│   ├── IPortfolioService.cs
│   └── PortfolioService.cs        # Assembles PortfolioViewModel
├── Repositories/
│   ├── IPortfolioRepository.cs
│   └── PortfolioRepository.cs     # All hardcoded content lives here
├── Models/
│   ├── Profile.cs
│   ├── Experience.cs
│   ├── SkillGroup.cs
│   ├── Education.cs
│   ├── Testimonial.cs
│   └── PortfolioViewModel.cs
├── Views/
│   ├── Shared/_Layout.cshtml      # Navbar, footer, CDN links
│   └── Home/Index.cshtml          # Full single-page site
└── wwwroot/
    ├── css/site.css               # Design system & all component styles
    └── js/site.js                 # Scroll shadow, active nav, mobile menu
```

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

All personal data is in [`Repositories/PortfolioRepository.cs`](Repositories/PortfolioRepository.cs). Edit the hardcoded values in each method to update your profile, experience, skills, education, and testimonials — no other files need to change.

## License

MIT
