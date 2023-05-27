using FreshFoodShop.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FreshFoodShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class FreshFoodBaseController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
   {
        private readonly TRepository Repository;
        public FreshFoodBaseController(TRepository Repository)
        {
            this.Repository = Repository;
        }
        // GET: api/<FreshFoodBaseController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await Repository.GetAll();
        }

        // GET api/<FreshFoodBaseController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var product = await Repository.Get(id);
            if(product == null)
            {
                return NotFound();
            }
            return product;
        }

        // POST api/<FreshFoodBaseController>
        [HttpPost,Route("Post")]
        public async Task<ActionResult<TEntity>> Post([FromBody] TEntity product)
        {
            await Repository.Add(product);
            return CreatedAtAction("Get", new { id = product.Id }, product);
        }

        // PUT api/<FreshFoodBaseController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] TEntity product)
        {
            if(id !=  product.Id )
            {
                return BadRequest();
            }
            await Repository.Update(product);
            return NoContent();
        }

        // DELETE api/<FreshFoodBaseController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var Entity = await Repository.Delete(id);
            if(Entity == null)
            {
                return NotFound();
            }
            return Entity;
        }
    }
}
