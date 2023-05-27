using FreshFoodShop.Data;

namespace FreshFoodShop.Models
{
    public class Orders : IEntity
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int CustomersId { get; set; }
        public Customers? Customers { get; set; }
    }
}
