using Microsoft.AspNetCore.Mvc;
using PAP.Services.Interfaces;

namespace PAP.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DogsAPIController : ControllerBase
    {
        private readonly IDogService _dogService;

        public DogsAPIController(IDogService dogService)
        {
            _dogService = dogService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllDogs()
        {
            var doggos = await _dogService.GetDogsAsync();
            return Ok(doggos);
        }
    }

}