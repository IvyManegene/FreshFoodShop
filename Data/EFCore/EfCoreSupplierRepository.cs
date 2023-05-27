using FreshFoodShop.Data.Repositories;
using FreshFoodShop.Models;

namespace FreshFoodShop.Data.EFCore
{
    public class EfCoreSupplierRepository : EfCoreRepository<Supplier, FreshFoodShopContext>
    {
        public EfCoreSupplierRepository(FreshFoodShopContext Context) : base(Context)
        {
        }
    }
}
