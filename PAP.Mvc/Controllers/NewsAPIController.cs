using Microsoft.AspNetCore.Mvc;
using NewsAPI.Models;
using PAP.Services;

namespace PAP.Mvc.Controllers
{
    public class NewsApiController : Controller
    {
        private readonly NewsAPIService _newsService;

        public NewsApiController()
        {
            _newsService = new NewsAPIService();
        }

        public IActionResult Index()
        {
            var news = _newsService.GetNews();
            return View(news);
        }
    }
}
