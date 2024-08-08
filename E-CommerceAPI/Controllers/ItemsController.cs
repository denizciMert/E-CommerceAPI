using E_CommerceAPI.Models;
using E_CommerceAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_CommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly MongoDbService _mongoDbService;

        public ItemsController(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }

        // GET: api/<İtemsController>
        [HttpGet]
        public async Task<List<Item>> Get()
        {
            return await _mongoDbService.GetAsync();
        }

        // GET api/<İtemsController>/5
        [HttpGet("{id}")]
        public async Task<Item> Get(string id)
        {
            return await _mongoDbService.GetByIdAsync(id);
        }

        // POST api/<İtemsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Item value)
        {
            await _mongoDbService.CreateAsync(value);
            return CreatedAtAction(nameof(Get), new { id = value.Id }, value);
        }

        // PUT api/<İtemsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] Item value)
        {
            await _mongoDbService.UpdateAsync(id, value);
            return CreatedAtAction(nameof(Get), new { id = value.Id }, value);
        }

        // DELETE api/<İtemsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _mongoDbService.DeleteAsync(id);
            return NoContent();
        }
    }
}
