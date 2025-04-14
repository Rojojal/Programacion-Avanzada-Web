using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using PAP.Models.Models;

namespace PAP.Mvc.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string apiKey = "06a49abe9fdf9afbf01f672a6fb7526b"; 

        public WeatherController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var cities = new List<string> { "Buenos Aires", "New York", "Tokyo" };
            var weatherData = new List<WeatherInfo>();
            var client = _httpClientFactory.CreateClient();

            foreach (var city in cities)
            {
                var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric&lang=es";

                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var data = JObject.Parse(json);

                    var weather = new WeatherInfo
                    {
                        City = city,
                        Description = data["weather"][0]["description"]!.ToString(),
                        Temperature = double.Parse(data["main"]["temp"]!.ToString()),
                        IconUrl = $"http://openweathermap.org/img/w/{data["weather"][0]["icon"]}.png"
                    };

                    weatherData.Add(weather);
                }
            }

            return View(weatherData);
        }
    }
}
