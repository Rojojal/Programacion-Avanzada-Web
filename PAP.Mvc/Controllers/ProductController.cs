using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using PAP.Business;
using PAP.Data.Models;

namespace PAP.Mvc.Controllers
{
    public class ProductController(IProductManager productManager) : Controller
    {
       
        // GET: ProductController
       public async Task<IActionResult> Index()
        {
            var products = await productManager.GetAllAsync();
            return View(products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            try
            {
                var newProduct = await productManager.AddProductAsync(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var edit = await productManager.GetByIdAsync(id);
            return View(edit);      
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(Product product)
        {
            try
            {
                var editProduct = await productManager.UpdateProductAsync(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var delete = await productManager.GetByIdAsync(id);
            return View(delete);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteAsync(Product product)
        {
            try
            {
                var deleteProduct = await productManager.DeleteProductAsync(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
