using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FreshFoodShop.Data;
using FreshFoodShop.Models;
using FreshFoodShop.Data.EFCore;

namespace FreshFoodShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : FreshFoodBaseController<Product, EfCoreProductRepository>
    {
        public ProductsController(EfCoreProductRepository Repository) : base(Repository)
        {
        }
    }
}
