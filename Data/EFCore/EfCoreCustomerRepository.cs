using FreshFoodShop.Data.Repositories;
using FreshFoodShop.Models;

namespace FreshFoodShop.Data.EFCore
{
    public class EfCoreCustomerRepository : EfCoreRepository<Customers, FreshFoodShopContext>
    {
        public EfCoreCustomerRepository(FreshFoodShopContext Context) : base(Context)
        {
        }
    }
}
