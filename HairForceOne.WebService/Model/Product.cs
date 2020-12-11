namespace HairForceOne.WebService.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Brand { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Weight { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal RetailPrice { get; set; }
        public string Color { get; set; }
        public string Gender { get; set; }

        public Product()
        {
        }
    }
}