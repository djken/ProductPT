namespace ProduitsPT.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }

        // Navigation property for related products
        public ICollection<Product> Products { get; set; }
    }

}
