namespace hr_bot_webapp_v2.Services
{
    using System;
    using System.Threading.Tasks;
    using hr_bot_webapp_v2.Data;

    public class SharedService
    {
        public Func<string, Task<string>> StartChatGPTServiceDirectInstance { get; set; }
        public Func<Task> GetJobInstance { get; set; }
    }
}
