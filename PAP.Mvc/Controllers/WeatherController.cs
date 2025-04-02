using Microsoft.AspNetCore.Mvc;
using PAP.Services;

namespace PAP.Mvc.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController(WeatherService weatherService) : ControllerBase
    {
        private readonly WeatherService _weatherService = weatherService;

        [HttpGet("current")]
        public async Task<IActionResult> GetCurrentWeather([FromQuery] double latitude, [FromQuery] double longitude)
        {
            var weather = await _weatherService.GetCurrentWeatherAsync(latitude, longitude);

            if (weather is null)
                return NotFound("Datos del clima no disponibles.");

            return Ok(weather);
        }
    }
}
