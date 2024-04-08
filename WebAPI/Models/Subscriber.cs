namespace WebAPI.Models
{
    public class Subscriber
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool DailyNewsletter { get; set; }
        public bool AdvertisingUpdates { get; set; }
        public bool WeekInReview { get; set; }
        public bool EventUpdates { get; set; }
        public bool StartupWeekly { get; set; }
        public bool Podcasts { get; set; }
    }
}
