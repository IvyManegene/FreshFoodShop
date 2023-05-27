using FreshFoodShop.Data.EFCore;
using FreshFoodShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreshFoodShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : FreshFoodBaseController<Customers, EfCoreCustomerRepository>
    {
        public CustomersController(EfCoreCustomerRepository Repository) : base(Repository)
        {
        }
    }
}
