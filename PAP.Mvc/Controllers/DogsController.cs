using Microsoft.AspNetCore.Mvc;
using PAP.Models.Models;
using PAP.Services.Services.Shared;	// ESTA LINEA ES NECESARIA

namespace PAP.Mvc.Controllers
{
    public class DogsController : Controller
    {
        private readonly HttpClient _http;

        public DogsController(IHttpClientFactory httpClientFactory)
        {
            _http = httpClientFactory.CreateClient();
        }

        public async Task<IActionResult> Index()
        {
            var dogs = await _http.GetFromJsonAsync<List<Dog>>("https://localhost:7027/api/dogsapi/all");

            await ConfigurationFetcher.FetchConfiguration(ViewBag); // ESTA LINEA ES NECESARIA

            return View(dogs);
        }
    }
}