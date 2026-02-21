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
        public double YearsOfExperience { get; set; }
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
                Platform = "GitHub",
                Url = "https://github.com/khushbu318",
                IconClass = "fab fa-github"
            },
            new SocialLink
            {
                Platform = "LinkedIn",
                Url = "https://www.linkedin.com/in/khushbu-kushvaha/",
                IconClass = "fab fa-linkedin"
            },
            new SocialLink
            {
                Platform = "Email",
                Url = "mailto:khushbu.kushvaha.work@gmail.com",
                IconClass = "fas fa-envelope"
            },
            new SocialLink
            {
                Platform = "Phone",
                Url = "tel:+919076015405",
                IconClass = "fas fa-phone"
            }

        };

        public static UserInfo Info = new UserInfo
        {
            Name = "Khushbu Kushvaha",
            Roles = new List<string>
            {
                "AI/ML Developer",
                "Generative AI Engineer",
                "Python Developer"
            },
            Bio = "Curious and adaptable AI/ML Developer with hands-on experience in building Gen AI prototypes, predictive models, and intelligent data tools using Python, React.js and LLM frameworks.",
            ProfileImage = "images/profile.jpg",
            ResumeLink = "files/Khushbu_Kushvaha.pdf",
            YearsOfExperience = 3.6,
            ProjectsCompleted = 5,
            About = "AI/ML professional experienced in Machine Learning, Time Series Forecasting, Generative AI, RAG pipelines and Agentic AI systems. Comfortable working across backend and frontend stacks, building automation tools, dashboards and intelligent applications that solve real-world business problems."
        };

        public static List<Project> Projects = new List<Project>
        {
            new Project
            {
                Title = "Healthcare Agentic AI Prior Authorization Framework",
                Description = "Contributed to a containerized multi-agent automation framework for healthcare prior authorization. Built FastAPI services, implemented event-driven pipelines using Google Pub/Sub, integrated Vertex AI (LLMs) for intelligent browser automation, and developed HITL & MFA workflows using n8n, PostgreSQL, and Redis.",
                Technologies = new List<string> { "FastAPI", "Vertex AI", "Google Pub/Sub", "PostgreSQL", "Redis", "n8n", "Docker", "LLMs" },
                GithubLink = "Enterprise Project – Private Repository"
            },
            new Project
            {
                Title = "Natural Language to SQL Intelligence Tool",
                Description = "Developed a system that converts natural language queries into SQL statements and visualizes insights using React and Google Charts, enabling non-technical users to perform data analysis efficiently.",
                Technologies = new List<string> { "Python", "SQL", "React.js", "Google Charts", "LLM Integration" },
                GithubLink = "Add GitHub project link here"
            },
            new Project
            {
                Title = "RAG-Based Enterprise Chatbot",
                Description = "Built a Retrieval-Augmented Generation (RAG) chatbot to assist developers with data migration and internal workflows, leveraging vector databases and LLM orchestration.",
                Technologies = new List<string> { "LangChain", "Semantic Kernel", "FAISS", "React.js", "Flask", "RAG" },
                GithubLink = "Add GitHub project link here"
            },
            new Project
            {
                Title = "Gen AI Invoice Processing & Fraud Detection System",
                Description = "Prototyped a multilingual invoice automation system using LLM pipelines to extract structured data and detect anomalies, improving financial processing accuracy.",
                Technologies = new List<string> { "AWS", "LLMs", "RAG", "Vector Databases", "Python" },
                GithubLink = "Add GitHub project link here"
            },
            new Project
            {
                Title = "Patient No-Show Prediction Model",
                Description = "Built a machine learning model to predict patient no-shows, improving scheduling efficiency. Integrated insights into interactive dashboards for data-driven decision making.",
                Technologies = new List<string> { "Python", "Machine Learning", "Streamlit", "Data Analysis" },
                GithubLink = "Add GitHub project link here"
            }
        };


        public static List<SkillCategory> Skills = new List<SkillCategory>
        {
            new SkillCategory
            {
                Title = "Programming Languages",
                Skills = new List<string> { "Python", "SQL", "JavaScript" }
            },
            new SkillCategory
            {
                Title = "Databases & Caching",
                Skills = new List<string> { "PostgreSQL", "SQLite", "Vector Databases", "Redis" }
            },
            new SkillCategory
            {
                Title = "Frameworks & Libraries",
                Skills = new List<string> 
                { 
                    "FastAPI", 
                    "Django", 
                    "Flask", 
                    "React.js", 
                    "Streamlit", 
                    "LangChain", 
                    "LangGraph", 
                    "Semantic Kernel", 
                    "FAISS", 
                    "Google ADK", 
                    "n8n"
                }
            },
            new SkillCategory
            {
                Title = "AI / Generative AI",
                Skills = new List<string> 
                { 
                    "Machine Learning", 
                    "Generative AI", 
                    "Prompt Engineering", 
                    "Retrieval-Augmented Generation (RAG)", 
                    "Agentic AI Frameworks", 
                    "LLM Orchestration", 
                    "Time Series Forecasting", 
                    "Data Analysis"
                }
            },
            new SkillCategory
            {
                Title = "Cloud & Event-Driven Systems",
                Skills = new List<string> 
                { 
                    "Google Cloud Platform (GCP)", 
                    "Google Pub/Sub", 
                    "Vertex AI", 
                    "Azure", 
                    "AWS"
                }
            },
            new SkillCategory
            {
                Title = "Tools & Dev Practices",
                Skills = new List<string> 
                { 
                    "Git", 
                    "GitHub Copilot", 
                    "Google Charts", 
                    "REST API Design", 
                    "RBAC Implementation", 
                    "System Design Thinking"
                }
            },
            new SkillCategory
            {
                Title = "Soft Skills",
                Skills = new List<string> 
                { 
                    "Project Leadership", 
                    "Problem-Solving", 
                    "Cross-Functional Collaboration", 
                    "Technical Learning Agility"
                }
            }
        };


        public static List<ExperienceInfo> Experiences = new List<ExperienceInfo>
        {
            new ExperienceInfo
            {
                Title = "AI Engineer",
                Company = "IKS Health",
                Duration = "Sep 2025 - Present",
                Description = "Designing FastAPI-based REST APIs and contributing to a containerized Agentic AI framework for healthcare automation. Implementing event-driven workflows using Google Pub/Sub, integrating Vertex AI (LLMs), and developing HITL & MFA processes using n8n, PostgreSQL, and Redis.",
                Skills = new List<string> 
                { 
                    "FastAPI", 
                    "Agentic AI", 
                    "Vertex AI", 
                    "Google Pub/Sub", 
                    "PostgreSQL", 
                    "Redis", 
                    "n8n" 
                }
            },
            new ExperienceInfo
            {
                Title = "Analyst (AI/ML Developer)",
                Company = "Capgemini",
                Duration = "2024 - Sep 2025",
                Description = "Monitored and optimized time series forecasting models using hana_ml to improve energy efficiency and reduce CO₂ emissions. Built multi-agent AI prototypes using Semantic Kernel, React, and Flask to automate enterprise workflows.",
                Skills = new List<string> 
                { 
                    "Time Series Forecasting", 
                    "Semantic Kernel", 
                    "Azure", 
                    "Agentic AI", 
                    "React.js" 
                }
            },
            new ExperienceInfo
            {
                Title = "Associate (Gen AI Developer)",
                Company = "Capgemini",
                Duration = "2023 - 2024",
                Description = "Developed Gen AI invoice automation systems, RAG-based chatbots, and natural language–to–SQL tools to enhance enterprise automation and business intelligence capabilities.",
                Skills = new List<string> 
                { 
                    "RAG", 
                    "LangChain", 
                    "AWS", 
                    "LLMs", 
                    "React.js" 
                }
            },
            new ExperienceInfo
            {
                Title = "Associate (Python Developer)",
                Company = "Capgemini",
                Duration = "Jul 2022 - 2023",
                Description = "Built predictive machine learning models and interactive Streamlit dashboards to improve scheduling efficiency and resource utilization across business units.",
                Skills = new List<string> 
                { 
                    "Python", 
                    "Machine Learning", 
                    "Streamlit", 
                    "Data Visualization" 
                }
            }
        };


        public static List<EducationInfo> EducationDetails = new List<EducationInfo>
        {
            new EducationInfo
            {
                Course = "B.Sc. Computer Science",
                Institution = "VES College of Arts, Science and Commerce, Mumbai",
                University = "University of Mumbai",
                YearOfCompletion = "2022",
                Score = "83.03%"
            },
            new EducationInfo
            {
                Course = "Higher Secondary Certificate (HSC)",
                Institution = "National Sarvodaya Junior College",
                University = "Maharashtra State Board",
                YearOfCompletion = "2019",
                Score = "62.42%"
            },
            new EducationInfo
            {
                Course = "Secondary School Certificate (SSC)",
                Institution = "Shree Sanatan Dharam Vidyalay",
                University = "Maharashtra State Board",
                YearOfCompletion = "2017",
                Score = "80.40%"
            }
        };


        public static ContactInfo Contact = new ContactInfo
        {
            Title = "Let's Build Intelligent Automation Systems Together",
            Description = "AI Engineer specializing in FastAPI, Agentic AI frameworks, and scalable backend systems for real-world automation.",
            CallToAction = "Open to AI Engineering, Backend, and Generative AI roles. Let's connect and build impactful systems!"
        };

    }
}
