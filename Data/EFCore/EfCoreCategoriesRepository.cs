using FreshFoodShop.Data.Repositories;
using FreshFoodShop.Models;

namespace FreshFoodShop.Data.EFCore
{
    public class EfCoreCategoriesRepository : EfCoreRepository<Categories, FreshFoodShopContext>
    {
        public EfCoreCategoriesRepository(FreshFoodShopContext Context) : base(Context)
        {
        }
    }
}
