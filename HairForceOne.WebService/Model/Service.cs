namespace HairForceOne.WebService.Models

{
    /// <summary>
    /// This class contains the properties for the Service instance
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Gets and sets the ServiceId
        /// </summary>
        public int ServiceId { get; set; }

        /// <summary>
        /// Gets and sets the Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets and sets the Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets and sets the Duration
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// Gets and sets the Price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the Gender
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets and sets the Type
        /// </summary>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Service"/>
        /// </summary>
        public Service()
        {
        }
    }
}