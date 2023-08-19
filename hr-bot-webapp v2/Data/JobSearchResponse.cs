namespace hr_bot_webapp_v2.Data
{
    public class JobData
    {
        public string employer_name { get; set; }
        public string employer_logo { get; set; }
        public string employer_website { get; set; }
        public string employer_company_type { get; set; }
        public string job_publisher { get; set; }
        public string job_id { get; set; }
        public string job_employment_type { get; set; }
        public string job_title { get; set; }
        public string job_apply_link { get; set; }
        public bool job_apply_is_direct { get; set; }
        public double job_apply_quality_score { get; set; }
        public string job_description { get; set; }
        public bool job_is_remote { get; set; }
        public int job_posted_at_timestamp { get; set; }
        public DateTime job_posted_at_datetime_utc { get; set; }
        public string job_city { get; set; }
        public string job_state { get; set; }
        public string job_country { get; set; }
        public double job_latitude { get; set; }
        public double job_longitude { get; set; }
        public object job_benefits { get; set; }
        public string job_google_link { get; set; }
        public DateTime? job_offer_expiration_datetime_utc { get; set; }
        public int? job_offer_expiration_timestamp { get; set; }
        public JobRequiredExperience job_required_experience { get; set; }
        public List<string> job_required_skills { get; set; }
        public JobRequiredEducation job_required_education { get; set; }
        public bool job_experience_in_place_of_education { get; set; }
        public object job_min_salary { get; set; }
        public object job_max_salary { get; set; }
        public object job_salary_currency { get; set; }
        public object job_salary_period { get; set; }
        public JobHighlights job_highlights { get; set; }
        public string job_job_title { get; set; }
        public string job_posting_language { get; set; }
        public string job_onet_soc { get; set; }
        public string job_onet_job_zone { get; set; }
        public string job_naics_code { get; set; }
        public string job_naics_name { get; set; }
        public List<string> job_occupational_categories { get; set; }
    }

    public class JobHighlights
    {
    }

    public class JobRequiredEducation
    {
        public bool postgraduate_degree { get; set; }
        public bool professional_certification { get; set; }
        public bool high_school { get; set; }
        public bool associates_degree { get; set; }
        public bool bachelors_degree { get; set; }
        public bool degree_mentioned { get; set; }
        public bool degree_preferred { get; set; }
        public bool professional_certification_mentioned { get; set; }
    }

    public class JobRequiredExperience
    {
        public bool no_experience_required { get; set; }
        public int? required_experience_in_months { get; set; }
        public bool experience_mentioned { get; set; }
        public bool experience_preferred { get; set; }
    }

    public class Parameters
    {
        public string query { get; set; }
        public int page { get; set; }
        public int num_pages { get; set; }
    }

    public class JobSearchResponse
    {
        public string status { get; set; }
        public string request_id { get; set; }
        public Parameters parameters { get; set; }
        public List<JobData> data { get; set; }
    }
}
