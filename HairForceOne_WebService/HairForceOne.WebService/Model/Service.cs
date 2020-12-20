namespace HairForceOne.WebService.Model

{
    /// <summary>
    /// This class contains the properties for the Service instance
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Gets and sets the ServiceId for the Service instance
        /// </summary>
        public int ServiceId { get; set; }

        /// <summary>
        /// Gets and sets the Title for the Service instance
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets and sets the Description for the Service instance
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets and sets the Duration in minuts for the Service instance
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Gets and sets the Price in DKK for the Service instance
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets and sets the Gender for the Service instance
        /// </summary>
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

        /// <summary>
        /// Initializes a new instance for the <see cref="Service"/>
        /// </summary>
        public Service()
        {
        }
    }
}