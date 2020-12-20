namespace HairForceOne.WinFormsDesktopClient.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Brand { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal RetailPrice { get; set; }
        public string Color { get; set; }
        public string Gender { get; set; }

        public Product(int ProductId_, string Brand_, string Title_, string Description_, decimal PurchasePrice_, decimal RetailPrice_, string Color_, string Gender_)
        {
            this.ProductId = ProductId_;
            this.Brand = Brand_;
            this.Title = Title_;
            this.Description = Description_;
            this.PurchasePrice = PurchasePrice_;
            this.RetailPrice = RetailPrice_;
            this.Color = Color_;
            this.Gender = Gender_;
        }
    }
}