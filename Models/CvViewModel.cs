namespace MyCvonAWS.Models
{
    public class CvViewModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string LinkedIn { get; set; }
        public string Summary { get; set; }
        public List<WorkExperience> WorkExperiences { get; set; }
        public List<Project> Projects { get; set; }
        public List<Education> Educations { get; set; } = new();
        public List<Skill> ProgrammingSkills { get; set; } = new();
        public List<Skill> DatabaseSkills { get; set; } = new();
        public List<Skill> ToolSkills { get; set; } = new();
    }

    public class WorkExperience
    {
        public string Company { get; set; }
        public string Period { get; set; }
        public List<string> Responsibilities { get; set; }
    }

    public class Project
    {
        public string Name { get; set; }
        public string Period { get; set; }
        public List<string> Details { get; set; }
    }

    public class Education
    {
        public string Institution { get; set; }
        public string Degree { get; set; }
        public string Period { get; set; }
        //public List<string> Details { get; set; }
    }

    public class Skill
    {
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; } // e.g., 0-100 for percentage
    }

}
