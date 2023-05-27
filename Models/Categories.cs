using FreshFoodShop.Data;

namespace FreshFoodShop.Models
{
    public class Categories : IEntity
    {
        public int Id { get; set; }
        public string?  Name { get; set; }  
        public string? Description { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
