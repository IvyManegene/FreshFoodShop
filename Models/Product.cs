using System.ComponentModel.DataAnnotations;
using FreshFoodShop.Data;

namespace FreshFoodShop.Models
{
	public class Product : IEntity
	{
        public int Id { get ; set ; }
        public string? Name { get; set ; }   
        public string? Description { get; set ; }
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ExpirationDate { get; set;}

        public int CategoriesId { get; set; }
        public Categories? Categories { get; set; }
        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }
    }
}