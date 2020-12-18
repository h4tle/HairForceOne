namespace HairForceOne.WebService.Model
{
    /// <summary>
    /// This class contains the properties for the Product instance
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets and sets the ProductId for the Product instance
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets and sets the Brand for the Product instance
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Gets and sets the Title for the Product instance
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets and sets the Description for the Product instance
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets and sets the PurchasePrice in DKK for the Product instance
        /// </summary>
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// Gets and sets the RetailsPrice in DKK for the Product instance
        /// </summary>
        public decimal RetailPrice { get; set; }

        /// <summary>
        /// Gets and sets the Gender for the Product instance
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets and sets the Quantity for the Product instance
        /// </summary>

        public int Quantity { get; set; }

        public Product(int ProductId_, string Brand_, string Title_, string Description_, decimal PurchasePrice_, decimal RetailPrice_, string Gender_, int Quantity_)
        {
            this.ProductId = ProductId_;
            this.Brand = Brand_;
            this.Title = Title_;
            this.Description = Description_;
            this.PurchasePrice = PurchasePrice_;
            this.RetailPrice = RetailPrice_;
            this.Gender = Gender_;
            this.Quantity = Quantity_;
        }

        /// <summary>
        /// Initializes a new instance for the <see cref="Product"/>
        /// </summary>
        public Product()
        {
        }
    }
}