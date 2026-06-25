# Configuration Guide

All configuration lives in JSON files under `Resources/`. You never need to edit C# code to change content, layout, or appearance — only the JSON files described here.

```
Resources/
├── JsonData/               # Your portfolio content
│   ├── Profile.json
│   ├── Experiences.json
│   ├── SkillGroups.json
│   ├── Education.json
│   ├── Certifications.json
│   ├── PersonalProjects.json
│   └── Testimonials.json
└── Settings/               # Display and layout settings
    ├── SectionSettings.json
    ├── FieldSettings.json
    ├── TitleSettings.json
    └── SEOSettings.json
```

---

## 1. Section Display and Order

**File:** `Resources/Settings/SectionSettings.json`

Controls which sections appear on the page and in what order.

```json
[
  { "key": "hero",         "enabled": true,  "order": 1 },
  { "key": "about",        "enabled": true,  "order": 2 },
  { "key": "experience",   "enabled": true,  "order": 3 },
  { "key": "certifications","enabled": false, "order": 4 },
  { "key": "projects",     "enabled": false, "order": 5 },
  { "key": "skills",       "enabled": true,  "order": 6 },
  { "key": "education",    "enabled": true,  "order": 7 },
  { "key": "testimonials", "enabled": false, "order": 8 },
  { "key": "contact",      "enabled": true,  "order": 9 }
]
```

| Field | Type | Description |
|---|---|---|
| `key` | string | Section identifier — do not change these values |
| `enabled` | boolean | `true` shows the section; `false` hides it (also removes it from the navbar) |
| `order` | number | Render order — lower numbers appear higher on the page |

**To enable the Certifications section** and move it above Skills:

```json
{ "key": "certifications", "enabled": true, "order": 4 },
{ "key": "skills",         "enabled": true, "order": 5 },
```

**To reorder** any section, update the `order` values. Gaps are fine — the renderer sorts by `order` numerically.

---

## 2. Field Display

**File:** `Resources/Settings/FieldSettings.json`

Controls which individual fields are shown within each section. Set any field to `false` to hide it without removing the data.

### Hero

```json
"hero": {
  "name": true,
  "title": true,
  "location": true,
  "openToOpportunities": true
}
```

| Field | Description |
|---|---|
| `name` | Your name displayed in the hero |
| `title` | Your job title / headline |
| `location` | Location badge below the headline |
| `openToOpportunities` | Green "Open to opportunities" badge |

### About

```json
"about": {
  "summary": true,
  "email": false,
  "location": true,
  "linkedIn": true,
  "gitHub": true,
  "fiverr": false,
  "upwork": true,
  "toptal": false,
  "freelancer": false,
  "guru": false,
  "peoplePerHour": false,
  "languages": true
}
```

Each platform link only appears when both its field is `true` **and** the corresponding URL is set in `Profile.json`.

### Experience

```json
"experience": {
  "company": true,
  "role": true,
  "period": true,
  "currentBadge": true,
  "projectName": true,
  "projectDescription": true,
  "projectHighlights": true,
  "projectTechnologies": true
}
```

`currentBadge` shows a "Current" label on your most recent role. The `project*` fields control the nested project details under each job.

### Skills

```json
"skills": {
  "icon": true,
  "category": true,
  "skillTags": true
}
```

`icon` shows the Bootstrap Icon next to each skill category. `skillTags` shows the individual skill pills.

### Education

```json
"education": {
  "institution": true,
  "degree": true,
  "period": true,
  "location": true,
  "gpa": false
}
```

Set `gpa` to `true` to display your GPA.

### Certifications

```json
"certifications": {
  "name": true,
  "issuer": true,
  "issuedOn": true,
  "expiresOn": true,
  "credentialUrl": true
}
```

`credentialUrl` renders as a "View credential" link. Remember to also enable the Certifications section in `SectionSettings.json`.

### Projects

```json
"projects": {
  "name": true,
  "description": true,
  "url": true,
  "year": true
}
```

### Testimonials

```json
"testimonials": {
  "quote": true,
  "author": true,
  "authorRole": true
}
```

### Contact

```json
"contact": {
  "email": true,
  "linkedIn": true,
  "fiverr": false,
  "upwork": true,
  "toptal": false,
  "freelancer": false,
  "guru": false,
  "peoplePerHour": false
}
```

Controls which contact buttons appear in the Contact section. Each button also requires the matching URL in `Profile.json`.

---

## 3. Wording and UI Text

**File:** `Resources/Settings/TitleSettings.json`

All user-visible text — section titles, taglines, button labels, and footer copy — is here. No Razor files need to be edited.

### Layout

```json
"layout": {
  "brandName": "vivanwicaksono",
  "footerText": "Built with ASP.NET Core MVC",
  "footerCredit": "Your Name"
}
```

`brandName` appears in the navbar top-left as the site logo/brand link.

### Hero

```json
"hero": {
  "greeting": "Hey, I'm",
  "tagline": "Your tagline here.",
  "ctaPrimary": "See My Work",
  "ctaSecondary": "Get in Touch",
  "openToOpportunities": "Open to opportunities"
}
```

`ctaPrimary` scrolls to the Experience section; `ctaSecondary` scrolls to Contact.

### About

```json
"about": {
  "tag": "About",
  "title": "A bit about me",
  "extraText": "A personal paragraph shown below your summary.",
  "languages": "English (professional) · Indonesian (native)"
}
```

`tag` is the small label shown above the section title. `extraText` is an additional paragraph you can use for anything personal.

### Section titles

Each remaining section has a `tag` and `title`:

```json
"experience":    { "tag": "Experience",    "title": "Where I've worked" },
"skills":        { "tag": "Skills",        "title": "What I work with" },
"education":     { "tag": "Education",     "title": "Academic background" },
"testimonials":  { "tag": "Testimonials",  "title": "What colleagues say" },
"certifications":{ "tag": "Certifications","title": "Licenses & certifications" },
"projects":      { "tag": "Projects",      "title": "Things I've built" }
```

### Contact section

```json
"contact": {
  "tag": "Contact",
  "title": "Let's connect",
  "description": "Your contact section intro text.",
  "emailButton": "Send me an email",
  "linkedInButton": "Connect on LinkedIn",
  "fiverrButton": "Hire me on Fiverr",
  "upworkButton": "Hire me on Upwork",
  "toptalButton": "Hire me on Toptal",
  "freelancerButton": "Hire me on Freelancer",
  "guruButton": "Hire me on Guru",
  "peoplePerHourButton": "Hire me on PeoplePerHour"
}
```

---

## 4. Images, Profile Picture, and Favicon

**File:** `Resources/Settings/TitleSettings.json` → `layout` and `hero` sections

| Setting | Default | Description |
|---|---|---|
| `hero.profileImage` | `/images/profile.jpg` | Profile photo shown in the Hero section |
| `hero.heroBackground` | `/images/hero-bg.png` | Background image behind the hero content |
| `layout.favicon` | `/favicon.ico` | Browser tab icon |
| `layout.touchIcon` | `/icon.png` | iOS/Android home screen icon |

**To replace the profile photo:**

1. Place your image in `wwwroot/images/` (e.g., `wwwroot/images/profile.jpg`)
2. Confirm the path in `TitleSettings.json` matches: `"profileImage": "/images/profile.jpg"`

**To replace the favicon:**

1. Place your `.ico` file in `wwwroot/` (e.g., `wwwroot/favicon.ico`)
2. Confirm `"favicon": "/favicon.ico"` in `TitleSettings.json`
3. For the touch icon, place a PNG (recommended 180×180 px) in `wwwroot/` and update `"touchIcon": "/icon.png"`

All paths are relative to `wwwroot/` and must start with `/`.

---

## 5. Portfolio Content (Data Files)

**Directory:** `Resources/JsonData/`

These files contain your actual portfolio data. Edit them to replace the placeholder content with your own.

### Profile.json

```json
{
  "name": "Your Name",
  "title": "Your Job Title",
  "summary": "A short bio shown in the About section.",
  "location": "City, Country",
  "email": "you@example.com",
  "phone": "",
  "linkedIn": "https://linkedin.com/in/yourprofile",
  "gitHub": "https://github.com/yourusername",
  "upwork": "",
  "fiverr": "",
  "toptal": "",
  "freelancer": "",
  "guru": "",
  "peoplePerHour": ""
}
```

Leave any platform URL empty (`""`) to hide that link, regardless of `FieldSettings.json`.

### Experiences.json

```json
[
  {
    "company": "Company Name",
    "companyLink": "https://company.com",
    "role": "Your Role",
    "period": "Jan 2020 – Present",
    "isCurrent": true,
    "projects": [
      {
        "name": "Project Name",
        "description": "What this project does.",
        "highlights": [
          "Key achievement or responsibility",
          "Another highlight"
        ],
        "technologies": ["C#", ".NET", "React"]
      }
    ]
  }
]
```

Each job can have multiple projects. `isCurrent: true` shows the "Current" badge (controlled also by `FieldSettings.experience.currentBadge`).

### SkillGroups.json

```json
[
  {
    "category": "Languages",
    "icon": "bi-code-slash",
    "skills": ["C#", "TypeScript", "SQL"]
  }
]
```

`icon` must be a valid [Bootstrap Icons](https://icons.getbootstrap.com/) name (e.g., `bi-cloud`, `bi-database`).

### Education.json

```json
[
  {
    "institution": "University Name",
    "institutionLink": "https://university.edu",
    "degree": "Bachelor of Computer Science",
    "period": "2010 – 2014",
    "gpa": "3.46",
    "location": "City, Country"
  }
]
```

### Certifications.json

```json
[
  {
    "name": "Certification Name",
    "issuer": "Issuing Organisation",
    "credentialUrl": "https://credential-link.com",
    "issuedOn": "Jan 2023",
    "expiresOn": "Jan 2026"
  }
]
```

Leave `expiresOn` empty (`""`) for certifications that do not expire. Remember to enable the Certifications section in `SectionSettings.json`.

### PersonalProjects.json

```json
[
  {
    "name": "Project Name",
    "description": "What the project does.",
    "url": "https://github.com/you/project",
    "year": "2024"
  }
]
```

### Testimonials.json

```json
[
  {
    "author": "Colleague Name",
    "authorRole": "Senior Engineer at Company",
    "quote": "Their testimonial text here."
  }
]
```

---

## 6. SEO Settings

**File:** `Resources/Settings/SEOSettings.json`

```json
{
  "siteUrl": "https://yoursite.com",
  "title": "Your Name — Job Title",
  "description": "Short description for search engines (150–160 characters recommended).",
  "keywords": "comma, separated, keywords",
  "author": "Your Name",
  "ogImage": "/images/profile.jpg",
  "ogType": "website",
  "twitterCard": "summary_large_image",
  "twitterHandle": "@yourhandle",
  "robots": "index, follow",
  "sitemap": {
    "enabled": true,
    "changefreq": "weekly",
    "priority": 0.8
  },
  "schema": {
    "enabled": true
  }
}
```

| Field | Description |
|---|---|
| `siteUrl` | Canonical URL of your deployed site — used in the sitemap and JSON-LD schema |
| `title` | `<title>` tag and Open Graph title |
| `description` | Meta description and Open Graph description |
| `keywords` | Meta keywords (minor SEO signal today, still useful for some crawlers) |
| `ogImage` | Image used when your page is shared on social media (absolute path from `wwwroot/`) |
| `twitterHandle` | Your Twitter/X handle including `@` — leave empty to omit the tag |
| `robots` | Robots meta tag; use `"noindex, nofollow"` to keep the site out of search results |
| `sitemap.enabled` | Generates `/sitemap.xml` when `true` |
| `sitemap.changefreq` | How often the page content changes: `always`, `hourly`, `daily`, `weekly`, `monthly`, `yearly`, `never` |
| `sitemap.priority` | Page priority hint for crawlers (0.0–1.0) |
| `schema.enabled` | Renders a JSON-LD `Person` schema block using your Profile data when `true` |

The sitemap is available at `/sitemap.xml` and robots.txt at `/robots.txt` once deployed.
