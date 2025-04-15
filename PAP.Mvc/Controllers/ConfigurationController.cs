using Azure;
using Microsoft.AspNetCore.Mvc;
using PAP.Models.Models;

namespace PAP.Mvc.Controllers
{
    public class ConfigurationController : Controller
    {
        private readonly HttpClient _http;

        public ConfigurationController(IHttpClientFactory httpClientFactory)
        {
            _http = httpClientFactory.CreateClient();
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            var config = await _http.GetFromJsonAsync<Configuration>("https://localhost:7027/api/configurationapi/all");

            return View(config);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Configuration config)
        {
            if (!ModelState.IsValid)
            {
                return View(config);
            }

            var response = await _http.PutAsJsonAsync("https://localhost:7027/api/configurationapi/update", config);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Edit");
            }

            ModelState.AddModelError(string.Empty, "Error updating Configuration!");

            return View(config);
        }
    }
}
