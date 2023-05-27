using FreshFoodShop.Data;
using FreshFoodShop.Data.EFCore;
using FreshFoodShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreshFoodShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : FreshFoodBaseController<Categories, EfCoreCategoriesRepository>
    {
        public CategoriesController(EfCoreCategoriesRepository Repository) : base(Repository)
        {
        }
    }
}
