using Microsoft.AspNetCore.Mvc;
using PAP.Business;
using PAP.Data.Models;

namespace PAP.Mvc.Controllers
{
    public abstract class MainController : Controller
    {
        private readonly IProductManager _productManager;
        public MainController(IProductManager productManager)
        {
            _productManager = productManager;
        }

        public async Task<IEnumerable<Product>> GetMyProductAsync()
        {
            return await _productManager.GetAllAsync();
        }
    }
}
