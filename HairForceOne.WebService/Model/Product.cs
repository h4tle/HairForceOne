namespace HairForceOne.WebService.Models
{
    /// <summary>
    /// This class contains the properties for the Product instance
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets and sets the ProductId
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets and sets the Brand
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Gets and sets the Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets and sets the Decription
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets and sets the Weight
        /// </summary>
        public string Weight { get; set; }

        /// <summary>
        /// Gets and sets the PurchasePrice
        /// </summary>
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// Gets and sets the RetailPrice
        /// </summary>
        public decimal RetailPrice { get; set; }

        /// <summary>
        /// Gets and sets the Color
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Gets and sets the Gender
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/>
        /// </summary>
        public Product()
        {
        }
    }
}