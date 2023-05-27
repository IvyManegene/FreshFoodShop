using FreshFoodShop.Data.Repositories;
using FreshFoodShop.Models;

namespace FreshFoodShop.Data.EFCore
{
    public class EfCoreProductRepository : EfCoreRepository<Product, FreshFoodShopContext>
    {
        public EfCoreProductRepository(FreshFoodShopContext Context) : base(Context)
        {
        }
    }
}
