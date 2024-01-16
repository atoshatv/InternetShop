namespace InternetShop.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string[] Photos { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public Product()
        {
            
        }
        public Product(Guid id, string[] photos, string title, decimal price)
        {
            Id = id;
            Photos = photos;
            Title = title;
            Price = price;
        }
    }
}
