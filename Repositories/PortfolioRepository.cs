using VivanPortfolio.Models;

namespace VivanPortfolio.Repositories;

public class PortfolioRepository : IPortfolioRepository
{
    public Profile GetProfile() => new()
    {
        Name = "Vivan Eko Wicaksono",
        Title = "Software Engineer · Full Stack Developer",
        Summary = "Software Engineer with 9+ years of experience designing, building, and maintaining production web applications in C#, the ASP.NET / .NET ecosystem, and JavaScript (jQuery, ReactJS, NextJS, TypeScript). Skilled at working with stakeholders to gather and analyse requirements and turn them into well-structured features. Has led a small Agile/Scrum development team while delivering complex business logic such as availability calculation and multi-currency pricing, deployed on Microsoft Azure with Azure DevOps CI/CD pipelines.",
        Location = "Blitar, Indonesia",
        Email = "vivanwicaksono@gmail.com",
        LinkedInUrl = "https://www.linkedin.com/in/vivanwicaksono",
        GitHubUrl = "https://github.com/vivanwicaksono",
        Phone = "+62 857 4608 5667"
    };

    public List<Experience> GetExperiences() =>
    [
        new()
        {
            Company = "PT. Mitrais",
            Role = "Software Engineer — Full Stack (Web Applications)",
            Period = "October 2021 – Present",
            IsCurrent = true,
            Projects =
            [
                new()
                {
                    Name = "Reservation Application",
                    Description = "Designed and developed a web-based reservation portal for agents and organisation users, covering reservation and reporting, availability calculation, multi-currency pricing, and automatic generation of reservation-product rules.",
                    Highlights =
                    [
                        "Led a small Agile/Scrum development team, running sprint planning and daily stand-ups while providing technical direction.",
                        "Implemented complex business logic including availability calculation and multi-currency pricing via .NET Web API + NextJS.",
                        "Built and deployed on Microsoft Azure using Azure DevOps CI/CD, Container Apps, PostgreSQL, Private DNS, and Key Vault."
                    ],
                    Technologies = [".NET Web API", "C#", "NextJS", "TypeScript", "Azure DevOps", "Azure Container Apps", "PostgreSQL", "Azure Key Vault"]
                },
                new()
                {
                    Name = "Third-Party Administrator (TPA) Insurance Platform",
                    Description = "Developed a web-based portal to manage cashless and reimbursement claims for insurance — four distinct portals: hospital, customer, master, and claim.",
                    Highlights =
                    [
                        "Optimized query loops to cut processing time — reimbursement upload handles 10,000 records in a single file without errors.",
                        "Implemented RabbitMQ messaging to keep the processing queue stable and recover gracefully during system glitches."
                    ],
                    Technologies = ["ASP.NET MVC", "C#", "SQL Server", "RabbitMQ", "jQuery", "Bootstrap"]
                }
            ]
        },
        new()
        {
            Company = "AXA Financial Indonesia",
            Role = "Software Engineer — Full Stack (Web Applications)",
            Period = "September 2020 – October 2021",
            IsCurrent = false,
            Projects =
            [
                new()
                {
                    Name = "Free Insurance Redemption Portal",
                    Description = "Developed a redemption portal for the partnership division (public and admin sites) with a voucher generator that creates up to 10,000 unique vouchers per action.",
                    Highlights =
                    [
                        "Portal's claimable-voucher metrics informed a successful phase 2 decision with the partner."
                    ],
                    Technologies = ["ASP.NET MVC", "C#", "SQL Server", "jQuery", "Bootstrap"]
                },
                new()
                {
                    Name = "Insurance E-buy Portal",
                    Description = "Developed and maintained an e-buy portal using ASP.NET MVC, jQuery, and Kentico, fixing front-end and back-end defects and building custom Kentico reports.",
                    Highlights =
                    [
                        "Helped grow Annual Premium Equivalent (APE) from e-commerce by over 100% in November 2020 by optimizing e-commerce pages."
                    ],
                    Technologies = ["ASP.NET MVC", "C#", "Kentico", "SQL Server", "jQuery"]
                },
                new()
                {
                    Name = "Insurance Payment Portal",
                    Description = "Developed the front end of the payment portal in ReactJS and resolved front-end defects to ensure correct behaviour across tablet and mobile screen sizes.",
                    Highlights = [],
                    Technologies = ["ReactJS", "JavaScript", "CSS"]
                }
            ]
        },
        new()
        {
            Company = "CV. Indosoft",
            Role = "Software Engineer — Full Stack (Web Applications)",
            Period = "March 2017 – September 2020",
            IsCurrent = false,
            Projects =
            [
                new()
                {
                    Name = "Scholarship Application Program",
                    Description = "Developed and maintained a scholarship platform with administrator, student, reviewer, reference, and selection-committee portals — covering scoring, document management, validation, and approval workflows.",
                    Highlights =
                    [
                        "Designed workflow across five stakeholder portals so each role focused on its own tasks, streamlining the university's end-to-end review process."
                    ],
                    Technologies = ["ASP.NET MVC", "C#", "MSSQL", "jQuery", "CSS"]
                }
            ]
        },
        new()
        {
            Company = "Aminah Hospital",
            Role = "Electronic Data Processing Division",
            Period = "December 2014 – March 2017",
            IsCurrent = false,
            Projects =
            [
                new()
                {
                    Name = "Hospital Information System",
                    Description = "Developed and maintained hospital applications, including medical record and sub-financial modules that reduced transaction time.",
                    Highlights = [],
                    Technologies = ["C#", "ASP.NET", "SQL Server"]
                }
            ]
        }
    ];

    public List<SkillGroup> GetSkillGroups() =>
    [
        new()
        {
            Category = "Languages",
            Icon = "bi-code-slash",
            Skills = ["C#", "JavaScript", "TypeScript", "jQuery", "HTML", "CSS"]
        },
        new()
        {
            Category = "Frameworks & Web",
            Icon = "bi-layers",
            Skills = [".NET Core", "ASP.NET MVC", "ASP.NET Web API", "Entity Framework", "LINQ", "ReactJS", "NextJS", "Bootstrap", "Kentico CMS", "WCF"]
        },
        new()
        {
            Category = "Databases",
            Icon = "bi-database",
            Skills = ["SQL Server (T-SQL)", "PostgreSQL", "MySQL", "MariaDB", "MongoDB", "SQLite"]
        },
        new()
        {
            Category = "Cloud & DevOps",
            Icon = "bi-cloud",
            Skills = ["Microsoft Azure", "Azure Container Apps", "Azure DevOps", "CI/CD Pipelines", "Azure Key Vault"]
        },
        new()
        {
            Category = "Tools & Testing",
            Icon = "bi-tools",
            Skills = ["Git", "Bitbucket", "RabbitMQ", "NUnit", "Postman"]
        },
        new()
        {
            Category = "Practices",
            Icon = "bi-person-workspace",
            Skills = ["Agile / Scrum", "Requirements Analysis", "Performance Optimization", "Code Reuse", "Small-Team Leadership"]
        }
    ];

    public List<Education> GetEducation() =>
    [
        new()
        {
            Institution = "State University of Malang",
            Degree = "Bachelor's Degree in Informatics Engineering",
            Period = "2010 – 2014",
            Gpa = "3.46",
            Location = "Malang, Indonesia"
        }
    ];

    public List<Testimonial> GetTestimonials() =>
    [
        new()
        {
            Author = "Aldi Dipasanta",
            AuthorRole = "Software Engineer",
            Quote = "Vivan is a curious fellow, always learning and spend his spare time to tinker about new technology. His particular interests was web development on both ends. Mild mannered with good sense of humor, it's really great experience to work with him. He is a proof example of a software developer with good hard skills and soft skills."
        },
        new()
        {
            Author = "Christian Rony",
            AuthorRole = "Quality Control",
            Quote = "Vivan worked as software developer. I was working with him for several years. His responsibilities included requirements gathering, analysis and design of complex web applications using a variety of technologies. Vivan proved himself to be a dependable programmer and a hard worker with solid problem solving and technical skills."
        },
        new()
        {
            Author = "Ramadhan Yunus",
            AuthorRole = "Game Developer",
            Quote = "It's great opportunity to work with him in Indosoft, undoubtedly he had great technical skill. But, the most I like about him is his personality and the best attitude you can find in fellow employee."
        }
    ];
}
