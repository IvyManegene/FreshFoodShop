using FreshFoodShop.Data.EFCore;
using FreshFoodShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreshFoodShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : FreshFoodBaseController<Orders, EfCoreOrderRepository>
    {
        public OrdersController(EfCoreOrderRepository Repository) : base(Repository)
        {
        }
    }
}
