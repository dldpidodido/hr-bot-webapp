using hr_bot_webapp_v2.Data;

namespace hr_bot_webapp_v2.Services;

public class Global
{
    public static Occupation Occupation = new Occupation();
    public static JobPosts JobPosts = new JobPosts();
}

public interface IList
{
    public void Clear();
}

public class JobPosts: IList
{
    public List<JobData> jobs;

    public void Clear()
    {
        jobs.Clear();
    }
}

public class Occupation: IList
{
    public class OccupationItem
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
    }

    public List<OccupationItem> allOccupations;

    public List<OccupationItem> GenerateAllOccupations()
    {
        return new List<OccupationItem>
        {
            new OccupationItem { Name = "Management", ImagePath = "/icons/architecture.svg"},
            new OccupationItem { Name = "Business", ImagePath = "/icons/business.svg" },
            new OccupationItem { Name = "Tech", ImagePath = "/icons/tech.svg" },
            new OccupationItem { Name = "Architecture & Engineering", ImagePath = "/icons/architecture.svg" },
            new OccupationItem { Name = "Science", ImagePath = "/icons/science.svg" },
            new OccupationItem { Name = "Social Service", ImagePath = "/icons/social-service.svg" },
            new OccupationItem { Name = "Legal", ImagePath = "/icons/legal.svg" },
            new OccupationItem { Name = "Education", ImagePath = "/icons/education.svg" },
            new OccupationItem { Name = "Art & Entertainment", ImagePath = "/icons/entertainment.svg" },
            new OccupationItem { Name = "Healthcare", ImagePath = "/icons/healthcare.svg" },
            new OccupationItem { Name = "Healthcare Support", ImagePath = "/icons/healthcare-support.svg" },
            new OccupationItem { Name = "Security", ImagePath = "/icons/security.svg" },
            new OccupationItem { Name = "Food Preparation", ImagePath = "/icons/food-service.svg" },
            new OccupationItem { Name = "Building Maintenance", ImagePath = "/icons/building-maintenance.svg" },
            new OccupationItem { Name = "Personal Care", ImagePath = "/icons/personal-care.svg" },
            new OccupationItem { Name = "Sales", ImagePath = "/icons/sales.svg" },
            new OccupationItem { Name = "Office", ImagePath = "/icons/office.svg" },
            new OccupationItem { Name = "Farming", ImagePath = "/icons/farming.svg" },
            new OccupationItem { Name = "Construction", ImagePath = "/icons/construction.svg" },
            new OccupationItem { Name = "Installation & Maintenance", ImagePath = "/icons/installation.svg" },
            new OccupationItem { Name = "Manufacturing", ImagePath = "/icons/manufacturing.svg" },
            new OccupationItem { Name = "Transportation", ImagePath = "/icons/transportation.svg" },
            new OccupationItem { Name = "Military", ImagePath = "/icons/military.svg" },
        };
    }

    public List<OccupationItem> GetVisibleOccupations(int visibleOccupationsCount)
    {
        return allOccupations.Take(visibleOccupationsCount).ToList();
    }

    public void Clear()
    {
        allOccupations.Clear();
    }
}
