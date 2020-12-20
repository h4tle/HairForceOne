namespace HairForceOne.WinFormsDesktopClient.Model
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }
        public string Gender { get; set; }

        public Service(int ServiceId_, string Title_, string Description_, int Duration_, decimal Price_, string Gender_)
        {
            this.ServiceId = ServiceId_;
            this.Title = Title_;
            this.Description = Description_;
            this.Duration = Duration_;
            this.Price = Price_;
            this.Gender = Gender_;
        }
    }
}