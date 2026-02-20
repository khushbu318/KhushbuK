using System.Collections.Generic;

namespace PortfolioSite.Models
{
    public class UserInfo
    {
        public string Name { get; set; } = default!;
        public List<string> Roles { get; set; } = default!;
        public string Bio { get; set; } = default!;
        public string About { get; set; } = default!;
        public string ProfileImage { get; set; } = default!;
        public string ResumeLink { get; set; } = default!;
        public int YearsOfExperience { get; set; }
        public int ProjectsCompleted { get; set; }
        public List<EducationInfo> EducationDetails { get; set; } = new();
    }

    public class Project
    {
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public List<string> Technologies { get; set; } = default!;
        public string GithubLink { get; set; } = default!;
    }

    public class SkillCategory
    {
        public string Title { get; set; } = default!;
        public List<string> Skills { get; set; } = default!;
    }

    public class ExperienceInfo
    {
        public string Title { get; set; } = default!;
        public string Company { get; set; } = default!;
        public string Duration { get; set; } = default!;
        public string Description { get; set; } = default!;
        public List<string> Skills { get; set; } = new();
    }

    public class SocialLink
    {
        public string Platform { get; set; } = default!;
        public string Url { get; set; } = default!;
        public string IconClass { get; set; } = default!;
    }

    public class ContactInfo
    {
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string CallToAction { get; set; } = default!;
    }

    public class EducationInfo
    {
        public string Course { get; set; } = default!;
        public string Institution { get; set; } = default!;
        public string University { get; set; } = default!;
        public string YearOfCompletion { get; set; } = default!;
        public string Score { get; set; } = default!;
    }

    public static class UserData
    {
        public static List<SocialLink> SocialLinks = new List<SocialLink>
        {
            new SocialLink
            {
                Platform = "Email",
                Url = "mailto:gadpalluamit1998@gmail.com",
                IconClass = "fas fa-envelope"
            },
            new SocialLink
            {
                Platform = "Phone",
                Url = "tel:+918411812941",
                IconClass = "fas fa-phone"
            },
            new SocialLink
            {
                Platform = "LinkedIn",
                Url = "https://www.linkedin.com/in/amit-gadpallu-008396168",
                IconClass = "fab fa-linkedin"
            }
        };

        public static UserInfo Info = new UserInfo
        {
            Name = "Amit Gadpallu",
            Roles = new List<string>
            {
                "Team Leader",
                "Professional Steel Detailer",
                "Tekla Structures Expert"
            },
            Bio = "Responsible Tekla Detailer with 5 years of experience in the steel detailing industry. Passionate about delivering outstanding quality, precise structural drawings, and leading teams to achieve business objectives.",
            ProfileImage = "images/profile.jpg",
            ResumeLink = "files/Amit_G_Resume.pdf",
            YearsOfExperience = 6,
            ProjectsCompleted = 4,
            About = "Experienced Tekla Detailer with strong knowledge of structural steel projects including commercial complexes, airports, hospitals and tilt-up projects. Skilled in design drawing analysis, OSHA safety standards, AISC/CISC/AWS compliance, BIM coordination, RFI handling, customized reports, advanced connection macros and team management."
        };

        public static List<Project> Projects = new List<Project>
        {
            new Project
            {
                Title = "Microsoft Commercial Complex (Buildings P, Q, N, O)",
                Description = "Steel detailing and modelling for large commercial complexes ensuring AISC compliance and high precision erection drawings.",
                Technologies = new List<string> { "Tekla Structures", "BIM", "Navisworks", "IFC" },
                GithubLink = ""
            },
            new Project
            {
                Title = "Thompson Regional Airport",
                Description = "Structural steel detailing for airport project including modelling, coordination and quality checks.",
                Technologies = new List<string> { "Tekla Structures", "Steel Detailing", "CAD" },
                GithubLink = ""
            },
            new Project
            {
                Title = "Snoqualmie Casino & Hospital Projects",
                Description = "Worked on casino and hospital projects including Scripps Stairs and UBC Gateway with detailed miscellaneous steel coordination.",
                Technologies = new List<string> { "Tekla Structures", "Misc Steel", "BIM Coordination" },
                GithubLink = ""
            },
            new Project
            {
                Title = "NE8th Tower & GSA Scottsdale",
                Description = "Handled structural modelling, project planning and coordination ensuring timely submissions and optimized resource utilization.",
                Technologies = new List<string> { "Tekla Structures", "Project Planning", "Steel Modelling" },
                GithubLink = ""
            }
        };

        public static List<SkillCategory> Skills = new List<SkillCategory>
        {
            new SkillCategory
            {
                Title = "Software & Tools",
                Skills = new List<string> { "Tekla Structures", "AutoCAD", "Navisworks", "IFC", "BIM Software" }
            },
            new SkillCategory
            {
                Title = "Technical Expertise",
                Skills = new List<string> { "Steel Detailing", "Miscellaneous Steel", "Erection Drawings", "Advanced Connection Macros", "Customized Components" }
            },
            new SkillCategory
            {
                Title = "Standards & Safety",
                Skills = new List<string> { "AISC", "CISC", "AWS", "OSHA Regulations" }
            },
            new SkillCategory
            {
                Title = "Leadership & Management",
                Skills = new List<string> { "Team Leadership", "Project Planning", "Resource Optimization", "Client Coordination", "Quality Assurance" }
            }
        };

        public static List<ExperienceInfo> Experiences = new List<ExperienceInfo>
        {
            new ExperienceInfo
            {
                Title = "Team Lead",
                Company = "Syneteca Engineering Solutions Pvt Ltd",
                Duration = "Sep 2024 - Present · 1 yr 6 mos",
                Description = "Leading a team of modelling and detailing engineers at Syneteca, driving project planning, task allocation, quality standards and timely deliverables for global steel detailing projects. Responsible for coaching junior team members, optimizing workflows, coordinating with clients and ensuring compliance with global industry standards.",
                Skills = new List<string>
                {
                    "Team Leadership",
                    "Project Planning",
                    "Tekla Structures",
                    "Quality Control",
                    "Client Coordination"
                }
            },

            new ExperienceInfo
            {
                Title = "Assistant Team Lead",
                Company = "Syneteca Engineering Solutions Pvt Ltd",
                Duration = "Nov 2022 - Sep 2024 · 1 yr 11 mos",
                Description = "Assisted in leading the modelling team and ensured accuracy in structural and miscellaneous steel detailing. Helped coordinate project timelines, review complex fabrication & erection drawings and supported client communication to achieve deliverables aligned with project requirements.",
                Skills = new List<string>
                {
                    "Tekla Modelling",
                    "Project Coordination",
                    "Drawing Review",
                    "Fabrication Planning",
                    "Team Support"
                }
            },

            new ExperienceInfo
            {
                Title = "Modeling Engineer",
                Company = "Syneteca Engineering Solutions Pvt Ltd",
                Duration = "Nov 2021 - Nov 2022 · 1 yr 1 mo",
                Description = "Performed detailed 3D steel modelling and structural detailing using Tekla Structures. Worked on commercial, industrial and infrastructure projects, ensuring accurate shop and erection drawings as per client specifications and industry standards.",
                Skills = new List<string>
                {
                    "3D Modelling (Tekla)",
                    "Structural Steel Detailing",
                    "Shop Drawings",
                    "Erection Drawings",
                    "OSHA/AISC Compliance"
                }
            },

            new ExperienceInfo
            {
                Title = "Trainee Engineer",
                Company = "Syneteca Engineering Solutions Pvt Ltd",
                Duration = "Sep 2019 - Nov 2021 · 2 yrs 3 mos",
                Description = "Started as a trainee focusing on learning structural steel detailing workflows, Tekla modelling and software processes. Supported project requirements and gained expertise in modelling techniques, drawing check processes and coordination with senior engineers.",
                Skills = new List<string>
                {
                    "Tekla Structures",
                    "Steel Detailing Fundamentals",
                    "Drawing Checks",
                    "Project Support",
                    "Team Collaboration"
                }
            }
        };


        public static List<EducationInfo> EducationDetails = new List<EducationInfo>
        {
            new EducationInfo
            {
                Course = "B.E. (Civil Engineering)",
                Institution = "JSPM Tathwade, Pune",
                University = "Savitribai Phule Pune University (SPPU)",
                YearOfCompletion = "2019",
                Score = "7.5 CGPA"
            }
        };

        public static ContactInfo Contact = new ContactInfo
        {
            Title = "Let's Build Structural Excellence",
            Description = "Professional Steel Detailer and Team Leader specializing in Tekla Structures and large-scale steel projects.",
            CallToAction = "Open to leadership roles, steel detailing projects, and collaboration opportunities."
        };
    }
}
