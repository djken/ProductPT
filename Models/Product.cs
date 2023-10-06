using System.ComponentModel.DataAnnotations.Schema;

namespace ProduitsPT.Models
{

    public class Product
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; } = 0; // Add this property

        // Foreign Key for User
        public int UserId { get; set; }

        // Navigation property for the related user
        public User User { get; set; }


    }

}

