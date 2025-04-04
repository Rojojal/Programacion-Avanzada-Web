using Microsoft.AspNetCore.Mvc;
using PAP.Business;
using PAP.Data.Models;

namespace PAP.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductAPIController(IProductManager manager) : Controller
    {
 
        private readonly IProductManager _manager = manager;


        [HttpGet("{id}", Name = "GetProduct")]
        public async Task<Product> Get(int id)
        {
            return await _manager.GetByIdAsync(id);
        }


        [HttpGet("all", Name = "GetAllProducts")]
        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _manager.GetAllAsync();
        }

 
        [HttpPost("save", Name = "SaveProduct")]
        public async Task<Product> Save([FromBody] Product product)
        {
            return null;
        }

        [HttpPut("{id}", Name = "UpdateProduct")]
        public async Task<Product> Update([FromBody] Product product)
        {
            return null;
        }


        [HttpDelete("delete", Name = "DeleteProduct")]
        public async Task<Product> Delete([FromBody] Product product)
        {
            return null;
        }

    }

}


