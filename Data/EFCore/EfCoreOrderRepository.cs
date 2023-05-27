using FreshFoodShop.Data.Repositories;
using FreshFoodShop.Models;

namespace FreshFoodShop.Data.EFCore
{
    public class EfCoreOrderRepository : EfCoreRepository<Orders, FreshFoodShopContext>
    {
        public EfCoreOrderRepository(FreshFoodShopContext Context) : base(Context)
        {
        }
    }
}
