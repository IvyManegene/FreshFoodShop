using FreshFoodShop.Data;

namespace FreshFoodShop.Models
{
    public class Supplier : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set;}
        public string? Email  { get; set; }
        public string?  PhoneNumber { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}