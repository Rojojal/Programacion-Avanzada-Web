using Microsoft.AspNetCore.Mvc;
using PAP.Services.Interfaces;
using PAP.Models.Models;
using System.Threading.Tasks;

namespace PAP.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfigurationAPIController : ControllerBase
    {
        private readonly IConfigurationService _configurationService;

        public ConfigurationAPIController(IConfigurationService configurationService)
        {
            _configurationService = configurationService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllConfiguration()
        {
            var config = await _configurationService.GetConfigurationAsync();
            return Ok(config);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateConfiguration([FromBody] Configuration config)
        {
            if (config == null)
                return BadRequest("Invalid configuration data.");

            if (config.FontSize < 4 || config.FontSize > 64)
                return BadRequest("FontSize must be between 4 and 64.");

            await _configurationService.UpdateConfigurationAsync(config);

            return Ok(new { message = "Updated configuration successfully." });
        }
    }
}