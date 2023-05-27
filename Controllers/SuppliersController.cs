using FreshFoodShop.Data.EFCore;
using FreshFoodShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreshFoodShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : FreshFoodBaseController<Supplier, EfCoreSupplierRepository>
    {
        public SuppliersController(EfCoreSupplierRepository Repository) : base(Repository)
        {
        }
    }
}
