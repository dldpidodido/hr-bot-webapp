using hr_bot_webapp_v2.Data;

namespace hr_bot_webapp_v2.Services
{
    public class JobInitService
    {
        public List<JobInit> JobInits { get; set; } = new List<JobInit>();

        // You can add methods to manipulate the data if needed
        public class JobInit
        {
            public string refTitle { get; set; }
            public List<JobData> Jobs;
        }
    }
}
