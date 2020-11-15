namespace HairForceOne.WebClient.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public double Price { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }

        public Service(int ServiceId_, string Title_, string Description_, string Duration_, double Price_, string Gender_, string Type_)
        {
            this.ServiceId = ServiceId_;
            this.Title = Title_;
            this.Description = Description_;
            this.Duration = Duration_;
            this.Price = Price_;
            this.Gender = Gender_;
            this.Type = Type_;
        }

        public Service()
        {
        }
    }
}